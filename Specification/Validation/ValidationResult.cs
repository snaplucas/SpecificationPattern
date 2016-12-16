using System.Collections.Generic;
using System.Linq;

namespace Specification.Validation
{
	public class ValidationResult
    {
		private readonly List<ValidationError> _erros;
		private string Message { get; set; }
		public IEnumerable<ValidationError> Erros { get; }
		public bool IsValid { get  { return !_erros.Any(); } }

		public ValidationResult()
		{
			_erros = new List<ValidationError>();
		}

		public void Add(ValidationError error)
		{
			_erros.Add(error);
		}
	}
}
