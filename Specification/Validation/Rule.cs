using Specification.Specification;

namespace Specification.Validation
{
	public class Rule<TEntity> : IRule<TEntity>
	{
		public Rule(ISpecification<TEntity> spec, string errorMessage)
		{
			ErrorMessage = errorMessage;
			Spec = spec;
		}

		public string ErrorMessage { get; }

		private ISpecification<TEntity> Spec;

		public bool Validate(TEntity entity)
		{
			return Spec.isSatisfiedby(entity);
		}
	}
}
