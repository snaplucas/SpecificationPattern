namespace Specification.Validation
{
	public interface IValidator<in TEntity>
	{
		ValidationResult Validate(TEntity entity);
	}
}
