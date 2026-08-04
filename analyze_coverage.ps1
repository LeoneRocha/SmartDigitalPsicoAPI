param(
    [string]$XmlPath = 'SmartDigitalPsico.Service.Test\coverage\coverage.cobertura.xml'
)
[xml]$xml = Get-Content $XmlPath
$classes = $xml.coverage.packages.package.classes.class
$results = foreach ($c in $classes) {
    $lines = $c.lines.line
    if ($null -eq $lines) { continue }
    $total = @($lines).Count
    $covered = @($lines | Where-Object { [int]$_.hits -gt 0 }).Count
    [PSCustomObject]@{
        Name    = $c.name
        Total   = $total
        Covered = $covered
        Missed  = $total - $covered
        Pct     = if ($total -gt 0) { [math]::Round(100 * $covered / $total, 1) } else { 100 }
    }
}
$top = $results | Sort-Object -Property Missed -Descending | Select-Object -First 60
foreach ($r in $top) {
    Write-Output ("{0,6} {1,6} {2,6} {3,6}%  {4}" -f $r.Missed, $r.Total, $r.Covered, $r.Pct, $r.Name)
}
