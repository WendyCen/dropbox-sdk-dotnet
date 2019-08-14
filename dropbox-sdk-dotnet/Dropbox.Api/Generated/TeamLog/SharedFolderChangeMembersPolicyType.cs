// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The shared folder change members policy type object</para>
    /// </summary>
    public class SharedFolderChangeMembersPolicyType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderChangeMembersPolicyType> Encoder = new SharedFolderChangeMembersPolicyTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderChangeMembersPolicyType> Decoder = new SharedFolderChangeMembersPolicyTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersPolicyType" /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public SharedFolderChangeMembersPolicyType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedFolderChangeMembersPolicyType" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedFolderChangeMembersPolicyType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the shared folder change members policy type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderChangeMembersPolicyType" />.</para>
        /// </summary>
        private class SharedFolderChangeMembersPolicyTypeEncoder : enc.StructEncoder<SharedFolderChangeMembersPolicyType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderChangeMembersPolicyType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderChangeMembersPolicyType" />.</para>
        /// </summary>
        private class SharedFolderChangeMembersPolicyTypeDecoder : enc.StructDecoder<SharedFolderChangeMembersPolicyType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedFolderChangeMembersPolicyType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderChangeMembersPolicyType Create()
            {
                return new SharedFolderChangeMembersPolicyType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderChangeMembersPolicyType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}