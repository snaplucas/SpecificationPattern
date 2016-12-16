using System;
using System.Collections.Generic;

namespace Specification.Validation
{
	public abstract class Validator<TEntity> : IValidator<TEntity> where TEntity : class
	{
		private readonly Dictionary<string, IRule<TEntity>> _validationsRules;

		protected Validator()
		{
			_validationsRules = new Dictionary<string, IRule<TEntity>>();
		}

		public ValidationResult Validate(TEntity entity)
		{
			var result = new ValidationResult();
			foreach (var key in _validationsRules.Keys)
			{
				var rule = _validationsRules[key];
				if (!rule.Validate(entity))
					result.Add(new ValidationError(rule.ErrorMessage));
			}
			return result;
		}

		protected virtual void Add(string name, IRule<TEntity> rule)
		{
			var ruleName = rule.GetType() + Guid.NewGuid().ToString("D");
			_validationsRules.Add(ruleName, rule);
		}
	}
}
