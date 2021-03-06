namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateBusinessRepositoryProjectsSetting
    /// </summary>
    public class UpdateBusinessRepositoryProjectsSettingInput
    {
        /// <summary>
        /// The ID of the business on which to set the repository projects setting.
        /// </summary>
        public ID BusinessId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}