﻿using GitCandy.App_GlobalResources;
using GitCandy.Base;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;
using System.Collections.Generic;

namespace GitCandy.Models
{
    public class RepositoryModel
    {
        [Required(ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_Required")]
        [StringLength(50, MinimumLength = 2, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_StringLengthRange")]
        [RegularExpression(RegularExpression.Repositoryname, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_Name")]
        [Display(ResourceType = typeof(SR), Name = "Repository_Name")]
        public String Name { get; set; }

        [StringLength(500, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_StringLength")]
        [Display(ResourceType = typeof(SR), Name = "Repository_Description")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public String Description { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_IsPrivate")]
        [UIHint("YesNo")]
        public bool IsPrivate { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_AllowAnonymousRead")]
        [UIHint("YesNo")]
        public bool AllowAnonymousRead { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_AllowAnonymousWrite")]
        [UIHint("YesNo")]
        public bool AllowAnonymousWrite { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_Collaborators")]
        [UIHint("Maps")]
        [AdditionalMetadata("Controller", "Account")]
        public IDictionary<String, String> Collaborators { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_Teams")]
        [UIHint("Maps")]
        [AdditionalMetadata("Controller", "Team")]
        public IDictionary<String, String> Teams { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Repository_DefaultBranch")]
        public String DefaultBranch { get; set; }

        public String[] LocalBranches { get; set; }

        public bool CurrentUserIsOwner { get; set; }

        public Int32 Commits { get; set; }
        public Int32 Branches { get; set; }
        public Int32 Contributors { get; set; }
        public DateTime LastCommit { get; set; }
        public Int32 Views { get; set; }
        public DateTime LastView { get; set; }
    }
}