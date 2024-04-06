namespace SmartDigitalPsico.Domain.Interfaces
{
    public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
