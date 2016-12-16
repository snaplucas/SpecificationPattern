namespace Specification.Specification
{
	public interface ISpecification<in T>
    {
		bool isSatisfiedby(T entity);
    }
}
