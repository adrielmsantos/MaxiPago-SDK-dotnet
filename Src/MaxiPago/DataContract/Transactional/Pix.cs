using System;
using System.Xml.Serialization;

namespace MaxiPago.DataContract.Transactional
{
  /// <summary>
  /// Class Pix.
  /// </summary>
  [Serializable]
  [XmlRoot(ElementName = "pix")]
  public class Pix
  {
    /// <summary>
    /// Gets or sets the expiration date.
    /// </summary>
    /// <value>The expiration date.</value>
    [XmlElement(ElementName = "expirationTime")]
    public string ExpirationTime { get; set; }

    /// <summary>
    /// Gets or sets the payment info.
    /// </summary>
    /// <value>The number.</value>
    [XmlElement(ElementName = "paymentInfo")]
    public string PaymentInfo { get; set; }
  }
}
