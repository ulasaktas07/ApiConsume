using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
	public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
	{
		public UpdateGuestValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty().WithMessage("Ad alanı boş geçilemez.")
				.MinimumLength(2).WithMessage("Ad en az 2 karakter olmalıdır.")
				.MaximumLength(50).WithMessage("Ad en fazla 50 karakter olmalıdır.");
			RuleFor(x => x.Surname)
				.NotEmpty().WithMessage("Soyad alanı boş geçilemez.")
				.MinimumLength(2).WithMessage("Soyad en az 2 karakter olmalıdır.")
				.MaximumLength(50).WithMessage("Soyad en fazla 50 karakter olmalıdır.");
			RuleFor(x => x.City)
				.NotEmpty().WithMessage("Şehir alanı boş geçilemez.")
				.MaximumLength(50).WithMessage("Şehir en fazla 50 karakter olmalıdır.")
			    .MinimumLength(2).WithMessage("Şehir en az 2 karakter olmalıdır.");

		}
	}
}
