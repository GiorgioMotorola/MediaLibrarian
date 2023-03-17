using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MediaLibrarian.Enums
{
    public enum ESRBRatingCategory
    {
        [Display(Name = "E")]
        E,
        [Display(Name = "T")]
        T,
        [Display(Name = "M")]
        M,
        [Display(Name = "A")]
        A,
        [Display(Name = "RP")]
        RP

    }
}
