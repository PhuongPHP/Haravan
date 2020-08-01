namespace WebHaravan.Models.Soonnoc
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("orders")]
        public List<Order> Order { get; set; }
        public long PageCount { get; set; }
        public int TotalPage { get; set; }
        public int? PageNumber { get; set; }
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
        public string CancelReason { get; set; }

        [JsonProperty("cancelled_at")]
        public string CancelledAt { get; set; }

        [JsonProperty("cart_token")]
        public string CartToken { get; set; }

        [JsonProperty("checkout_token")]
        public string CheckoutToken { get; set; }

        [JsonProperty("client_details")]
        public ClientDetails ClientDetails { get; set; }

        [JsonProperty("closed_at")]
        public string ClosedAt { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("customer")]
        public Customer Customer { get; set; }

        [JsonProperty("discount_codes")]
        public List<object> DiscountCodes { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("financial_status")]
        public string FinancialStatus { get; set; }

        [JsonProperty("fulfillments")]
        public List<object> Fulfillments { get; set; }

        [JsonProperty("fulfillment_status")]
        public string FulfillmentStatus { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("gateway_code")]
        public string GatewayCode { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("landing_site")]
        public string LandingSite { get; set; }

        [JsonProperty("landing_site_ref")]
        public string LandingSiteRef { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("line_items")]
        public List<LineItem> LineItems { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        [JsonProperty("processing_method")]
        public string ProcessingMethod { get; set; }

        [JsonProperty("referring_site")]
        public string ReferringSite { get; set; }

        [JsonProperty("refunds")]
        public List<object> Refunds { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }

        [JsonProperty("shipping_lines")]
        public List<ShippingLine> ShippingLines { get; set; }

        [JsonProperty("source_name")]
        public string SourceName { get; set; }

        [JsonProperty("subtotal_price")]
        public long SubtotalPrice { get; set; }

        [JsonProperty("tax_lines")]
        public string TaxLines { get; set; }

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
        public List<Transaction> Transactions { get; set; }

        [JsonProperty("note_attributes")]
        public List<object> NoteAttributes { get; set; }

        [JsonProperty("confirmed_at")]
        public string ConfirmedAt { get; set; }

        [JsonProperty("closed_status")]
        public string ClosedStatus { get; set; }

        [JsonProperty("cancelled_status")]
        public string CancelledStatus { get; set; }

        [JsonProperty("confirmed_status")]
        public string ConfirmedStatus { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("ref_order_id")]
        public long RefOrderId { get; set; }

        [JsonProperty("ref_order_number")]
        public string RefOrderNumber { get; set; }

        [JsonProperty("utm_source")]
        public string UtmSource { get; set; }

        [JsonProperty("utm_medium")]
        public string UtmMedium { get; set; }

        [JsonProperty("utm_campaign")]
        public string UtmCampaign { get; set; }

        [JsonProperty("utm_term")]
        public string UtmTerm { get; set; }

        [JsonProperty("utm_content")]
        public string UtmContent { get; set; }

        [JsonProperty("redeem_model")]
        public string RedeemModel { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

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
        public string Ward { get; set; }

        [JsonProperty("ward_code")]
        public string WardCode { get; set; }

        [JsonProperty("latitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Latitude { get; set; }

        [JsonProperty("longitude", NullValueHandling = NullValueHandling.Ignore)]
        public string Longitude { get; set; }
    }

    public partial class ClientDetails
    {
        [JsonProperty("accept_language")]
        public string AcceptLanguage { get; set; }

        [JsonProperty("browser_ip")]
        public string BrowserIp { get; set; }

        [JsonProperty("session_hash")]
        public string SessionHash { get; set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("browser_height")]
        public string BrowserHeight { get; set; }

        [JsonProperty("browser_width")]
        public string BrowserWidth { get; set; }
    }

    public partial class Customer
    {
        [JsonProperty("accepts_marketing")]
        public bool AcceptsMarketing { get; set; }

        [JsonProperty("addresses")]
        public List<Address> Addresses { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("default_address")]
        public Address DefaultAddress { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("multipass_identifier")]
        public string MultipassIdentifier { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("last_order_id")]
        public long LastOrderId { get; set; }

        [JsonProperty("last_order_name")]
        public string LastOrderName { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("orders_count")]
        public long OrdersCount { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

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
        public string Password { get; set; }

        [JsonProperty("password_confirmation")]
        public string PasswordConfirmation { get; set; }

        [JsonProperty("group_name")]
        public string GroupName { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("last_order_date")]
        public string LastOrderDate { get; set; }
    }

    public partial class LineItem
    {
        [JsonProperty("fulfillable_quantity")]
        public long FulfillableQuantity { get; set; }

        [JsonProperty("fulfillment_service")]
        public string FulfillmentService { get; set; }

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
        public long? ProductId { get; set; }

        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        [JsonProperty("requires_shipping")]
        public bool RequiresShipping { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("variant_id")]
        public long? VariantId { get; set; }

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
        public string TaxLines { get; set; }

        [JsonProperty("product_exists")]
        public bool ProductExists { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("properties")]
        public string Properties { get; set; }

        [JsonProperty("total_discount")]
        public long TotalDiscount { get; set; }

        [JsonProperty("applied_discounts")]
        public List<object> AppliedDiscounts { get; set; }

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
        public string Attactment { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }
    }

    public partial class ShippingLine
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public partial class Transaction
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("authorization")]
        public string Authorization { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("receipt")]
        public string Receipt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("test")]
        public bool Test { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("payment_details")]
        public string PaymentDetails { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("haravan_transaction_id")]
        public string HaravanTransactionId { get; set; }

        [JsonProperty("external_transaction_id")]
        public string ExternalTransactionId { get; set; }

        [JsonProperty("send_email")]
        public bool SendEmail { get; set; }
    }

    public partial class Page
    {
        
        public long Count { get; set; }
        public int TotalPage { get; set; }
    }
}
