// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The group members remove arg object</para>
    /// </summary>
    public class GroupMembersRemoveArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupMembersRemoveArg> Encoder = new GroupMembersRemoveArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupMembersRemoveArg> Decoder = new GroupMembersRemoveArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembersRemoveArg" />
        /// class.</para>
        /// </summary>
        /// <param name="group">The group</param>
        /// <param name="users">The users</param>
        public GroupMembersRemoveArg(GroupSelector @group,
                                     col.IEnumerable<UserSelectorArg> users)
        {
            if (@group == null)
            {
                throw new sys.ArgumentNullException("@group");
            }

            var usersList = enc.Util.ToList(users);

            if (users == null)
            {
                throw new sys.ArgumentNullException("users");
            }

            this.Group = @group;
            this.Users = usersList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembersRemoveArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupMembersRemoveArg()
        {
        }

        /// <summary>
        /// <para>Gets the group of the group members remove arg</para>
        /// </summary>
        public GroupSelector Group { get; protected set; }

        /// <summary>
        /// <para>Gets the users of the group members remove arg</para>
        /// </summary>
        public col.IList<UserSelectorArg> Users { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupMembersRemoveArg" />.</para>
        /// </summary>
        private class GroupMembersRemoveArgEncoder : enc.StructEncoder<GroupMembersRemoveArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupMembersRemoveArg value, enc.IJsonWriter writer)
            {
                WriteProperty("group", value.Group, writer, Dropbox.Api.Team.GroupSelector.Encoder);
                WriteListProperty("users", value.Users, writer, Dropbox.Api.Team.UserSelectorArg.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupMembersRemoveArg" />.</para>
        /// </summary>
        private class GroupMembersRemoveArgDecoder : enc.StructDecoder<GroupMembersRemoveArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupMembersRemoveArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupMembersRemoveArg Create()
            {
                return new GroupMembersRemoveArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupMembersRemoveArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group":
                        value.Group = Dropbox.Api.Team.GroupSelector.Decoder.Decode(reader);
                        break;
                    case "users":
                        value.Users = ReadList<UserSelectorArg>(reader, Dropbox.Api.Team.UserSelectorArg.Decoder);
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