using System;

namespace Macaco.Infraestructure.Domain
{
    /// <summary>
    /// The base class for domain entities.
    /// </summary>
    public abstract class EntityBase : IValidatable
    {
        /// <summary>
        /// The validation errors
        /// </summary>
        private ValidationErrors _validationErrors;

        public abstract string Key { get; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsValid()
        {
            _validationErrors.Clear();
            Validate();
            return GetValidationErrors().Items.Count == 0;
        }

        /// <summary>
        /// Gets the validation errors.
        /// </summary>
        /// <value>
        /// The validation errors.
        /// </value>
        public virtual ValidationErrors GetValidationErrors()
        {
            return _validationErrors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityBase" /> class.
        /// </summary>
        protected EntityBase()
        {
            _validationErrors = new ValidationErrors();
        }

        protected virtual void Validate() { }
    }

    public interface IValidatable
    {
        bool IsValid();
        ValidationErrors GetValidationErrors();
    }
}