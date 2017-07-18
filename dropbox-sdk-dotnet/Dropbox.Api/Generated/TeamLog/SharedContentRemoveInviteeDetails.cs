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
    /// <para>Removed an invitee from the membership of a shared file or folder before it was
    /// claimed.</para>
    /// </summary>
    public class SharedContentRemoveInviteeDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentRemoveInviteeDetails> Encoder = new SharedContentRemoveInviteeDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentRemoveInviteeDetails> Decoder = new SharedContentRemoveInviteeDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveInviteeDetails" /> class.</para>
        /// </summary>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        public SharedContentRemoveInviteeDetails(long targetIndex,
                                                 string originalFolderName)
        {
            if (originalFolderName == null)
            {
                throw new sys.ArgumentNullException("originalFolderName");
            }

            this.TargetIndex = targetIndex;
            this.OriginalFolderName = originalFolderName;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SharedContentRemoveInviteeDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentRemoveInviteeDetails()
        {
        }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentRemoveInviteeDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveInviteeDetailsEncoder : enc.StructEncoder<SharedContentRemoveInviteeDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentRemoveInviteeDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentRemoveInviteeDetails" />.</para>
        /// </summary>
        private class SharedContentRemoveInviteeDetailsDecoder : enc.StructDecoder<SharedContentRemoveInviteeDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SharedContentRemoveInviteeDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentRemoveInviteeDetails Create()
            {
                return new SharedContentRemoveInviteeDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentRemoveInviteeDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
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