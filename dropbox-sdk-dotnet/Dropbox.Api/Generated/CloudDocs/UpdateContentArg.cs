// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.CloudDocs
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The update content arg object</para>
    /// </summary>
    public class UpdateContentArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UpdateContentArg> Encoder = new UpdateContentArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UpdateContentArg> Decoder = new UpdateContentArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateContentArg" />
        /// class.</para>
        /// </summary>
        /// <param name="fileId">The file id</param>
        /// <param name="actorTokens">A list of auth_tokens, one for each editor who made
        /// changes to the document since the last call to update_content.</param>
        /// <param name="additionalContents">Currently, this will always be empty until we
        /// implement upload_additional_content.</param>
        public UpdateContentArg(string fileId,
                                col.IEnumerable<string> actorTokens,
                                col.IEnumerable<Content> additionalContents = null)
        {
            if (fileId == null)
            {
                throw new sys.ArgumentNullException("fileId");
            }
            if (fileId.Length < 4)
            {
                throw new sys.ArgumentOutOfRangeException("fileId", "Length should be at least 4");
            }
            if (!re.Regex.IsMatch(fileId, @"\A(?:id:.+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("fileId", @"Value should match pattern '\A(?:id:.+)\z'");
            }

            var actorTokensList = enc.Util.ToList(actorTokens);

            if (actorTokens == null)
            {
                throw new sys.ArgumentNullException("actorTokens");
            }

            var additionalContentsList = enc.Util.ToList(additionalContents);

            this.FileId = fileId;
            this.ActorTokens = actorTokensList;
            this.AdditionalContents = additionalContentsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UpdateContentArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UpdateContentArg()
        {
        }

        /// <summary>
        /// <para>Gets the file id of the update content arg</para>
        /// </summary>
        public string FileId { get; protected set; }

        /// <summary>
        /// <para>A list of auth_tokens, one for each editor who made changes to the document
        /// since the last call to update_content.</para>
        /// </summary>
        public col.IList<string> ActorTokens { get; protected set; }

        /// <summary>
        /// <para>Currently, this will always be empty until we implement
        /// upload_additional_content.</para>
        /// </summary>
        public col.IList<Content> AdditionalContents { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UpdateContentArg" />.</para>
        /// </summary>
        private class UpdateContentArgEncoder : enc.StructEncoder<UpdateContentArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UpdateContentArg value, enc.IJsonWriter writer)
            {
                WriteProperty("file_id", value.FileId, writer, enc.StringEncoder.Instance);
                WriteListProperty("actor_tokens", value.ActorTokens, writer, enc.StringEncoder.Instance);
                if (value.AdditionalContents.Count > 0)
                {
                    WriteListProperty("additional_contents", value.AdditionalContents, writer, global::Dropbox.Api.CloudDocs.Content.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UpdateContentArg" />.</para>
        /// </summary>
        private class UpdateContentArgDecoder : enc.StructDecoder<UpdateContentArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UpdateContentArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UpdateContentArg Create()
            {
                return new UpdateContentArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UpdateContentArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_id":
                        value.FileId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "actor_tokens":
                        value.ActorTokens = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "additional_contents":
                        value.AdditionalContents = ReadList<Content>(reader, global::Dropbox.Api.CloudDocs.Content.Decoder);
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