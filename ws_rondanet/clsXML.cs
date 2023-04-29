using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace ws_rondanet
{
    [XmlRoot(ElementName = "from")]
    public class From
    {
        [XmlElement(ElementName = "gln")]
        public string Gln { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "to")]
    public class To
    {
        [XmlElement(ElementName = "gln")]
        public string Gln { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "messageRondaHeader")]
    public class MessageRondaHeader
    {
        [XmlElement(ElementName = "from")]
        public From From { get; set; }
        [XmlElement(ElementName = "to")]
        public To To { get; set; }
        [XmlElement(ElementName = "creationDateTime")]
        public string CreationDateTime { get; set; }
    }

    [XmlRoot(ElementName = "buyer")]
    public class Buyer
    {
        [XmlElement(ElementName = "gln")]
        public string Gln { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "seller")]
    public class Seller
    {
        [XmlElement(ElementName = "gln")]
        public string Gln { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "shipTo")]
    public class ShipTo
    {
        [XmlElement(ElementName = "gln")]
        public string Gln { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "orderLineItem")]
    public class OrderLineItem
    {
        /// <summary>
        /// Global Trade Item Number
        /// </summary>
        [XmlElement(ElementName = "itemIdGtin")]
        public string ItemIdGtin { get; set; }

        /// <summary>
        /// Identificador del producto para el cliente (comprador)
        /// </summary>
        [XmlElement(ElementName = "itemIdBuyerCode")]
        public string ItemIdBuyerCode { get; set; }

        /// <summary>
        /// Identificador del producto para el proveedor (vendedor)
        /// </summary>
        [XmlElement(ElementName = "itemIdSellerCode")]
        public string ItemIdSellerCode { get; set; }
        [XmlElement(ElementName = "itemDescription")]
        public string ItemDescription { get; set; }
        [XmlElement(ElementName = "itemBrandName")]
        public string ItemBrandName { get; set; }
        [XmlElement(ElementName = "itemRequestedQuantity")]
        public string ItemRequestedQuantity { get; set; }
        [XmlElement(ElementName = "netUnitPrice")]
        public string NetUnitPrice { get; set; }

        /// <summary>
        /// Tipo de empaquetado
        /// </summary>
        [XmlElement(ElementName = "packageType")]
        public string PackageType { get; set; }

        /// <summary>
        /// Cantidad de empaques
        /// </summary>
        [XmlElement(ElementName = "numberOfPackages")]
        public string NumberOfPackages { get; set; }
        [XmlAttribute(AttributeName = "number")]
        public string Number { get; set; }
    }

    [XmlRoot(ElementName = "messageRondaBody")]
    public class MessageRondaBody
    {
        [XmlElement(ElementName = "entityType")]
        public string EntityType { get; set; }
        [XmlElement(ElementName = "uniqueCreatorIdentification")]
        public string UniqueCreatorIdentification { get; set; }
        [XmlElement(ElementName = "documentDate")]
        public string DocumentDate { get; set; }
        [XmlElement(ElementName = "latestDeliveryDate")]
        public string LatestDeliveryDate { get; set; }
        [XmlElement(ElementName = "documentRemarks")]
        public string DocumentRemarks { get; set; }
        [XmlElement(ElementName = "buyer")]
        public Buyer Buyer { get; set; }
        [XmlElement(ElementName = "seller")]
        public Seller Seller { get; set; }
        [XmlElement(ElementName = "shipTo")]
        public ShipTo ShipTo { get; set; }
        [XmlElement(ElementName = "transactionCurrency")]
        public string TransactionCurrency { get; set; }
        [XmlElement(ElementName = "orderLineItem")]
        public List<OrderLineItem> OrderLineItem { get; set; }
        [XmlElement(ElementName = "requestedDeliveryDate")]
        public string RequestedDeliveryDate { get; set; }
        [XmlElement(ElementName = "termsGroup")]
        public TermsGroup TermsGroup { get; set; }
    }

    [XmlRoot(ElementName = "messageRonda")]
    public class MessageRonda
    {
        [XmlElement(ElementName = "messageRondaHeader")]
        public MessageRondaHeader MessageRondaHeader { get; set; }
        [XmlElement(ElementName = "messageRondaBody")]
        public MessageRondaBody MessageRondaBody { get; set; }
        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "codedPaymentTerms")]
    public class CodedPaymentTerms
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "idByBuyer")]
        public string IdByBuyer { get; set; }
        [XmlAttribute(AttributeName = "idBySeller")]
        public string IdBySeller { get; set; }
    }

    [XmlRoot(ElementName = "termsGroup")]
    public class TermsGroup
    {
        [XmlElement(ElementName = "codedPaymentTerms")]
        public CodedPaymentTerms CodedPaymentTerms { get; set; }
    }

    [XmlRoot(ElementName = "envelopeRonda")]
    public class EnvelopeRonda
    {
        [XmlElement(ElementName = "messageRonda")]
        public List<MessageRonda> MessageRonda { get; set; }
    }
}
