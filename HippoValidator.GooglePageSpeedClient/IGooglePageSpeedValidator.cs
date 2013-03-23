using System;

namespace HippoValidator.GooglePageSpeedClient
{
    public interface IGooglePageSpeedValidator
    {
        ValidationResult Validate(Uri url);
    }
}