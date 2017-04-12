/* 
 * ShipEngine
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ShipEngine.ApiClient.Model
{
    /// <summary>
    ///     PaginationLinkDTO
    /// </summary>
    [DataContract]
    public class PaginationLinkDTO : IEquatable<PaginationLinkDTO>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PaginationLinkDTO" /> class.
        /// </summary>
        /// <param name="first">First.</param>
        /// <param name="last">Last.</param>
        /// <param name="prev">Prev.</param>
        /// <param name="next">Next.</param>
        /// <param name="href">The url for the link..</param>
        /// <param name="type">The object type that can be found at the url..</param>
        public PaginationLinkDTO(LinkDTO first = default(LinkDTO), LinkDTO last = default(LinkDTO),
            LinkDTO prev = default(LinkDTO), LinkDTO next = default(LinkDTO), string href = default(string),
            string type = default(string))
        {
            First = first;
            Last = last;
            Prev = prev;
            Next = next;
            Href = href;
            Type = type;
        }

        /// <summary>
        ///     Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        public LinkDTO First { get; set; }

        /// <summary>
        ///     Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", EmitDefaultValue = false)]
        public LinkDTO Last { get; set; }

        /// <summary>
        ///     Gets or Sets Prev
        /// </summary>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public LinkDTO Prev { get; set; }

        /// <summary>
        ///     Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public LinkDTO Next { get; set; }

        /// <summary>
        ///     The url for the link.
        /// </summary>
        /// <value>The url for the link.</value>
        [DataMember(Name = "href", EmitDefaultValue = false)]
        public string Href { get; set; }

        /// <summary>
        ///     The object type that can be found at the url.
        /// </summary>
        /// <value>The object type that can be found at the url.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        ///     Returns true if PaginationLinkDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of PaginationLinkDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationLinkDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
            {
                return false;
            }

            return
                (
                    Equals(First, other.First) ||
                    First != null &&
                    First.Equals(other.First)
                ) &&
                (
                    Equals(Last, other.Last) ||
                    Last != null &&
                    Last.Equals(other.Last)
                ) &&
                (
                    Equals(Prev, other.Prev) ||
                    Prev != null &&
                    Prev.Equals(other.Prev)
                ) &&
                (
                    Equals(Next, other.Next) ||
                    Next != null &&
                    Next.Equals(other.Next)
                ) &&
                (
                    Href == other.Href ||
                    Href != null &&
                    Href.Equals(other.Href)
                ) &&
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                );
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginationLinkDTO {\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return Equals(obj as PaginationLinkDTO);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                var hash = 41;
                // Suitable nullity checks etc, of course :)
                if (First != null)
                {
                    hash = hash * 59 + First.GetHashCode();
                }
                if (Last != null)
                {
                    hash = hash * 59 + Last.GetHashCode();
                }
                if (Prev != null)
                {
                    hash = hash * 59 + Prev.GetHashCode();
                }
                if (Next != null)
                {
                    hash = hash * 59 + Next.GetHashCode();
                }
                if (Href != null)
                {
                    hash = hash * 59 + Href.GetHashCode();
                }
                if (Type != null)
                {
                    hash = hash * 59 + Type.GetHashCode();
                }
                return hash;
            }
        }
    }
}