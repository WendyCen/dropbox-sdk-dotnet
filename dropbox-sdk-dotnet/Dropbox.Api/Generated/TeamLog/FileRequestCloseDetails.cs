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
    /// <para>Closed a file request.</para>
    /// </summary>
    public class FileRequestCloseDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestCloseDetails> Encoder = new FileRequestCloseDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestCloseDetails> Decoder = new FileRequestCloseDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestCloseDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="requestTitle">File request title.</param>
        public FileRequestCloseDetails(string requestTitle)
        {
            if (requestTitle == null)
            {
                throw new sys.ArgumentNullException("requestTitle");
            }

            this.RequestTitle = requestTitle;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestCloseDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestCloseDetails()
        {
        }

        /// <summary>
        /// <para>File request title.</para>
        /// </summary>
        public string RequestTitle { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestCloseDetails" />.</para>
        /// </summary>
        private class FileRequestCloseDetailsEncoder : enc.StructEncoder<FileRequestCloseDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestCloseDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("request_title", value.RequestTitle, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestCloseDetails" />.</para>
        /// </summary>
        private class FileRequestCloseDetailsDecoder : enc.StructDecoder<FileRequestCloseDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRequestCloseDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestCloseDetails Create()
            {
                return new FileRequestCloseDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestCloseDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "request_title":
                        value.RequestTitle = enc.StringDecoder.Instance.Decode(reader);
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