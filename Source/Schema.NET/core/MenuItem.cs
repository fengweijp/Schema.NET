namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    [DataContract]
    public partial class MenuItem : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuItem";

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<NutritionInformation>? Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RestrictedDiet?>? SuitableForDiet { get; set; }
    }
}
