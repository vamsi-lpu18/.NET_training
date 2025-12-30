namespace Security.Authentication
{
    class FacialFeatures
    {
       
        public string EyeColor { get; }
        public decimal PhiltrumWidth { get; }    
        public FacialFeatures(string eyeColor, decimal philtrumWidth)
        {
            EyeColor = eyeColor;
            PhiltrumWidth = philtrumWidth;
        }

        
        public override bool Equals(object obj)
        {
            
            if (ReferenceEquals(this, obj))
                return true;

          
            FacialFeatures other = obj as FacialFeatures;
            if (other == null)
                return false;

            return Equals(other);
        }
        public bool Equals(FacialFeatures other)
        {
            if (other == null)
                return false;

            return EyeColor == other.EyeColor &&
                   PhiltrumWidth == other.PhiltrumWidth;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(EyeColor, PhiltrumWidth);
        }
    }

    class Identity
    {
        public string Email;
        public FacialFeatures FacialFeatures;

        public Identity(string email, FacialFeatures facialFeatures)
        {
            Email = email;
            FacialFeatures = facialFeatures;
        }
    }

    class Authenticator
    {
    }
}
