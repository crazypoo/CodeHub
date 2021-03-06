using CodeHub.Core.Services;

namespace CodeHub.Core.ViewModels.Users
{
    public class RepositoryCollaboratorsViewModel : BaseUsersViewModel
    {
        private readonly ISessionService _applicationService;

        public string RepositoryOwner { get; set; }

        public string RepositoryName { get; set; }

        public RepositoryCollaboratorsViewModel(ISessionService applicationService)
        {
            _applicationService = applicationService;
            Title = "Collaborators";
        }

        protected override GitHubSharp.GitHubRequest<System.Collections.Generic.List<GitHubSharp.Models.BasicUserModel>> CreateRequest()
        {
            return _applicationService.Client.Users[RepositoryOwner].Repositories[RepositoryName].GetCollaborators();
        }
    }
}

