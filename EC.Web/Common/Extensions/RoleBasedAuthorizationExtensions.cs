using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using System;

namespace EC.Web.Common.Extensions
{
    public static class RoleBasedAuthorizationExtensions
    {
        public static PageConventionCollection AuthorizeAreaFolder(this PageConventionCollection conventions, string areaName, string folderPath, string[] roles)
        {
            if (conventions == null)
            {
                throw new ArgumentNullException(nameof(conventions));
            }

            if (string.IsNullOrEmpty(areaName))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(areaName));
            }

            if (string.IsNullOrEmpty(folderPath))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(folderPath));
            }

            var policy = new AuthorizationPolicyBuilder().
                RequireRole(roles).Build();
            var authorizeFilter = new AuthorizeFilter(policy);
            conventions.AddAreaFolderApplicationModelConvention(areaName, folderPath, model => model.Filters.Add(authorizeFilter));
            return conventions;
        }

        public static PageConventionCollection AuthorizeAreaPage(this PageConventionCollection conventions, string areaName, string pageName, string[] roles)
        {
            if (conventions == null)
            {
                throw new ArgumentNullException(nameof(conventions));
            }

            if (string.IsNullOrEmpty(areaName))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(areaName));
            }

            if (string.IsNullOrEmpty(pageName))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(pageName));
            }

            var policy = new AuthorizationPolicyBuilder().
                RequireRole(roles).Build();
            var authorizeFilter = new AuthorizeFilter(policy);
            conventions.AddAreaPageApplicationModelConvention(areaName, pageName, model => model.Filters.Add(authorizeFilter));
            return conventions;
        }

        public static PageConventionCollection AuthorizeFolder(this PageConventionCollection conventions, string folderPath, string[] roles)
        {
            if (conventions == null)
            {
                throw new ArgumentNullException(nameof(conventions));
            }

            if (string.IsNullOrEmpty(folderPath))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(folderPath));
            }

            var policy = new AuthorizationPolicyBuilder().
                RequireRole(roles).Build();
            var authorizeFilter = new AuthorizeFilter(policy);
            conventions.AddFolderApplicationModelConvention(folderPath, model => model.Filters.Add(authorizeFilter));
            return conventions;
        }

        public static PageConventionCollection AuthorizePage(this PageConventionCollection conventions, string pageName, string[] roles)
        {
            if (conventions == null)
            {
                throw new ArgumentNullException(nameof(conventions));
            }

            if (string.IsNullOrEmpty(pageName))
            {
                throw new ArgumentException("Argument cannot be null or empty.", nameof(pageName));
            }

            var policy = new AuthorizationPolicyBuilder().
                RequireRole(roles).Build();
            var authorizeFilter = new AuthorizeFilter(policy);
            conventions.AddPageApplicationModelConvention(pageName, model => model.Filters.Add(authorizeFilter));
            return conventions;
        }
    }
}
