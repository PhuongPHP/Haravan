namespace WebHaravan.Models.Gomi
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class WelcomeGomi
    {
        [JsonProperty("products")]
        public Product Product { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        [JsonProperty("body_plain")]
        public string BodyPlain { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("published_at")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("published_scope")]
        public string PublishedScope { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("variants")]
        public List<Variant> Variants { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }

        [JsonProperty("only_hide_from_list")]
        public bool OnlyHideFromList { get; set; }

        [JsonProperty("not_allow_promotion")]
        public bool NotAllowPromotion { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("attachment")]
        public string Attachment { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("variant_ids")]
        public List<object> VariantIds { get; set; }
    }

    public partial class Option
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }
    }

    public partial class Variant
    {
        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("compare_at_price")]
        public long CompareAtPrice { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

        [JsonProperty("grams")]
        public long Grams { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("inventory_management")]
        public string InventoryManagement { get; set; }

        [JsonProperty("inventory_policy")]
        public string InventoryPolicy { get; set; }

        [JsonProperty("inventory_quantity")]
        public long InventoryQuantity { get; set; }

        [JsonProperty("old_inventory_quantity")]
        public long OldInventoryQuantity { get; set; }

        [JsonProperty("inventory_quantity_adjustment")]
        public string InventoryQuantityAdjustment { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("image_id")]
        public string ImageId { get; set; }

        [JsonProperty("option1")]
        public string Option1 { get; set; }

        [JsonProperty("option2")]
        public string Option2 { get; set; }

        [JsonProperty("option3")]
        public string Option3 { get; set; }

        [JsonProperty("inventory_advance")]
        public string InventoryAdvance { get; set; }
    }
}
