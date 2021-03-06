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
    /// <para>Changed who can update a setting.</para>
    /// </summary>
    public class EnterpriseSettingsLockingDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<EnterpriseSettingsLockingDetails> Encoder = new EnterpriseSettingsLockingDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<EnterpriseSettingsLockingDetails> Decoder = new EnterpriseSettingsLockingDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="EnterpriseSettingsLockingDetails" /> class.</para>
        /// </summary>
        /// <param name="teamName">The secondary team name.</param>
        /// <param name="settingsPageName">Settings page name.</param>
        /// <param name="previousSettingsPageLockingState">Previous locked settings page
        /// state.</param>
        /// <param name="newSettingsPageLockingState">New locked settings page state.</param>
        public EnterpriseSettingsLockingDetails(string teamName,
                                                string settingsPageName,
                                                string previousSettingsPageLockingState,
                                                string newSettingsPageLockingState)
        {
            if (teamName == null)
            {
                throw new sys.ArgumentNullException("teamName");
            }

            if (settingsPageName == null)
            {
                throw new sys.ArgumentNullException("settingsPageName");
            }

            if (previousSettingsPageLockingState == null)
            {
                throw new sys.ArgumentNullException("previousSettingsPageLockingState");
            }

            if (newSettingsPageLockingState == null)
            {
                throw new sys.ArgumentNullException("newSettingsPageLockingState");
            }

            this.TeamName = teamName;
            this.SettingsPageName = settingsPageName;
            this.PreviousSettingsPageLockingState = previousSettingsPageLockingState;
            this.NewSettingsPageLockingState = newSettingsPageLockingState;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="EnterpriseSettingsLockingDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public EnterpriseSettingsLockingDetails()
        {
        }

        /// <summary>
        /// <para>The secondary team name.</para>
        /// </summary>
        public string TeamName { get; protected set; }

        /// <summary>
        /// <para>Settings page name.</para>
        /// </summary>
        public string SettingsPageName { get; protected set; }

        /// <summary>
        /// <para>Previous locked settings page state.</para>
        /// </summary>
        public string PreviousSettingsPageLockingState { get; protected set; }

        /// <summary>
        /// <para>New locked settings page state.</para>
        /// </summary>
        public string NewSettingsPageLockingState { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="EnterpriseSettingsLockingDetails" />.</para>
        /// </summary>
        private class EnterpriseSettingsLockingDetailsEncoder : enc.StructEncoder<EnterpriseSettingsLockingDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(EnterpriseSettingsLockingDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("team_name", value.TeamName, writer, enc.StringEncoder.Instance);
                WriteProperty("settings_page_name", value.SettingsPageName, writer, enc.StringEncoder.Instance);
                WriteProperty("previous_settings_page_locking_state", value.PreviousSettingsPageLockingState, writer, enc.StringEncoder.Instance);
                WriteProperty("new_settings_page_locking_state", value.NewSettingsPageLockingState, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="EnterpriseSettingsLockingDetails" />.</para>
        /// </summary>
        private class EnterpriseSettingsLockingDetailsDecoder : enc.StructDecoder<EnterpriseSettingsLockingDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="EnterpriseSettingsLockingDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override EnterpriseSettingsLockingDetails Create()
            {
                return new EnterpriseSettingsLockingDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(EnterpriseSettingsLockingDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "team_name":
                        value.TeamName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "settings_page_name":
                        value.SettingsPageName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_settings_page_locking_state":
                        value.PreviousSettingsPageLockingState = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_settings_page_locking_state":
                        value.NewSettingsPageLockingState = enc.StringDecoder.Instance.Decode(reader);
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
