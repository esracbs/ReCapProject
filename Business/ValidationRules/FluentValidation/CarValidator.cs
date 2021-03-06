﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Descriptions).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(50);
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(10).When(c => c.ColorId == 1);
        }
    }
}
