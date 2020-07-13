using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebHaravan.Models.Soonnoc
{

    public partial class Welcome
    {
        [JsonProperty("order")]
        public Order Order { get; set; }
    }

    public partial class Order
    {
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("buyer_accepts_marketing")]
        public bool BuyerAcceptsMarketing { get; set; }

        [JsonProperty("cancel_reason")]
        public object CancelReason { get; set; }

        [JsonProperty("cancelled_at")]
        public object CancelledAt { get; set; }

        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        [JsonProperty("checkout_token")]
        public string CheckoutToken { get; set; }

        [JsonProperty("client_details")]
        public ClientDetails ClientDetails { get; set; }

        [JsonProperty("closed_at")]
        public object ClosedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("discount_codes")]
        public object[] DiscountCodes { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        [JsonProperty("fulfillments")]
        public object[] Fulfillments { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("tags")]
        public object Tags { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("gateway_code")]
        public string GatewayCode { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        [JsonProperty("landing_site_ref")]
        public object LandingSiteRef { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("processing_method")]
        public object ProcessingMethod { get; set; }

        [JsonProperty("referring_site")]
        public object ReferringSite { get; set; }

        [JsonProperty("refunds")]
        public object[] Refunds { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonProperty("shipping_lines")]
        public ShippingLine[] ShippingLines { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("subtotal_price")]
        public long SubtotalPrice { get; set; }

        [JsonProperty("tax_lines")]
        public object TaxLines { get; set; }

        [JsonProperty("taxes_included")]
        public bool TaxesIncluded { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("total_discounts")]
        public long TotalDiscounts { get; set; }

        [JsonProperty("total_line_items_price")]
        public long TotalLineItemsPrice { get; set; }

        [JsonProperty("total_price")]
        public long TotalPrice { get; set; }

        [JsonProperty("total_tax")]
        public long TotalTax { get; set; }

        [JsonProperty("total_weight")]
        public long TotalWeight { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("transactions")]
        public Transaction[] Transactions { get; set; }

        [JsonProperty("note_attributes")]
        public object[] NoteAttributes { get; set; }

        [JsonProperty("confirmed_at")]
        public object ConfirmedAt { get; set; }

        [JsonProperty("closed_status")]
        public string ClosedStatus { get; set; }

        [JsonProperty("cancelled_status")]
        public string CancelledStatus { get; set; }

        [JsonProperty("confirmed_status")]
        public string ConfirmedStatus { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("device_id")]
        public object DeviceId { get; set; }

        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("ref_order_id")]
        public long RefOrderId { get; set; }

        [JsonProperty("ref_order_number")]
        public object RefOrderNumber { get; set; }

        [JsonProperty("utm_source")]
        public object UtmSource { get; set; }

        [JsonProperty("utm_medium")]
        public object UtmMedium { get; set; }

        [JsonProperty("utm_campaign")]
        public object UtmCampaign { get; set; }

        [JsonProperty("utm_term")]
        public object UtmTerm { get; set; }

        [JsonProperty("utm_content")]
        public object UtmContent { get; set; }

        [JsonProperty("redeem_model")]
        public object RedeemModel { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public object Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("company")]
        public object Company { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("province_code")]
        public string ProvinceCode { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("district_code")]
        public string DistrictCode { get; set; }

        [JsonProperty("ward")]
        public object Ward { get; set; }

        [JsonProperty("ward_code")]
        public object WardCode { get; set; }

        [JsonProperty("latitude")]
        public object Latitude { get; set; }

        [JsonProperty("longitude")]
        public object Longitude { get; set; }
    }

    public partial class ClientDetails
    {
        [JsonProperty("accept_language")]
        public object AcceptLanguage { get; set; }

        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("session_hash")]
        public object SessionHash { get; set; }

        [JsonProperty("user_agent")]
        public object UserAgent { get; set; }

        [JsonProperty("browser_height")]
        public object BrowserHeight { get; set; }

        [JsonProperty("browser_width")]
        public object BrowserWidth { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonProperty("addresses")]
        public Address[] Addresses { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("default_address")]
        public Address DefaultAddress { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("first_name")]
        public object FirstName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("multipass_identifier")]
        public object MultipassIdentifier { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_order_id")]
        public long LastOrderId { get; set; }

        [JsonProperty("last_order_name")]
        public string LastOrderName { get; set; }

        [JsonProperty("note")]
        public object Note { get; set; }

        [JsonProperty("orders_count")]
        public long OrdersCount { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tags")]
        public object Tags { get; set; }

        [JsonProperty("total_spent")]
        public long TotalSpent { get; set; }

        [JsonProperty("total_paid")]
        public long TotalPaid { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("verified_email")]
        public bool VerifiedEmail { get; set; }

        [JsonProperty("send_email_invite")]
        public bool SendEmailInvite { get; set; }

        [JsonProperty("send_email_welcome")]
        public bool SendEmailWelcome { get; set; }

        [JsonProperty("password")]
        public object Password { get; set; }

        [JsonProperty("password_confirmation")]
        public object PasswordConfirmation { get; set; }

        [JsonProperty("group_name")]
        public object GroupName { get; set; }

        [JsonProperty("birthday")]
        public object Birthday { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("last_order_date")]
        public object LastOrderDate { get; set; }
    }

    public partial class LineItem
    {
        [JsonProperty("fulfillable_quantity")]
        public long FulfillableQuantity { get; set; }

        [JsonProperty("fulfillment_service")]
        public object FulfillmentService { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("grams")]
        public long Grams { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("price_original")]
        public long PriceOriginal { get; set; }

        [JsonProperty("price_promotion")]
        public long PricePromotion { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variant_id")]
        public long VariantId { get; set; }

        [JsonProperty("variant_title")]
        public string VariantTitle { get; set; }

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("gift_card")]
        public bool GiftCard { get; set; }

        [JsonProperty("taxable")]
        public bool Taxable { get; set; }

        [JsonProperty("tax_lines")]
        public object TaxLines { get; set; }

        [JsonProperty("product_exists")]
        public bool ProductExists { get; set; }

        [JsonProperty("barcode")]
        public object Barcode { get; set; }

        [JsonProperty("properties")]
        public object Properties { get; set; }

        [JsonProperty("total_discount")]
        public long TotalDiscount { get; set; }

        [JsonProperty("applied_discounts")]
        public object[] AppliedDiscounts { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("not_allow_promotion")]
        public bool NotAllowPromotion { get; set; }

        [JsonProperty("ma_cost_amount")]
        public long MaCostAmount { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("attactment")]
        public object Attactment { get; set; }

        [JsonProperty("filename")]
        public object Filename { get; set; }
    }

    public partial class ShippingLine
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("source")]
        public object Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("authorization")]
        public object Authorization { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("device_id")]
        public object DeviceId { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("receipt")]
        public object Receipt { get; set; }

        [JsonProperty("status")]
        public object Status { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("payment_details")]
        public object PaymentDetails { get; set; }

        [JsonProperty("parent_id")]
        public object ParentId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("haravan_transaction_id")]
        public object HaravanTransactionId { get; set; }

        [JsonProperty("external_transaction_id")]
        public object ExternalTransactionId { get; set; }

        [JsonProperty("send_email")]
        public bool SendEmail { get; set; }
    }

    //public partial class Welcome
    //{
    //    public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, WebHaravan.Models.Soonnoc.Converter.Settings);
    //}

    //public static class Serialize
    //{
    //    public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, WebHaravan.Models.Soonnoc.Converter.Settings);
    //}

    //internal static class Converter
    //{
    //    public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
    //    {
    //        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
    //        DateParseHandling = DateParseHandling.None,
    //        Converters =
    //        {
    //            new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
    //        },
    //    };
    //}
}
