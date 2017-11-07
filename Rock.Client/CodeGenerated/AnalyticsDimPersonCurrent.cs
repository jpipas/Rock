//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// <copyright>
// Copyright by the Spark Development Network
//
// Licensed under the Rock Community License (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.rockrms.com/license
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;


namespace Rock.Client
{
    /// <summary>
    /// Base client model for AnalyticsDimPersonCurrent that only includes the non-virtual fields. Use this for PUT/POSTs
    /// </summary>
    public partial class AnalyticsDimPersonCurrentEntity
    {
        /// <summary />
        public int Id { get; set; }

        /// <summary />
        public int? Age { get; set; }

        /// <summary />
        public DateTime? AnniversaryDate { get; set; }

        /// <summary />
        public int? BirthDateKey { get; set; }

        /// <summary />
        public int? BirthDay { get; set; }

        /// <summary />
        public int? BirthMonth { get; set; }

        /// <summary />
        public int? BirthYear { get; set; }

        /// <summary />
        public string ConnectionStatus { get; set; }

        /// <summary />
        public int? ConnectionStatusValueId { get; set; }

        /// <summary />
        public bool CurrentRowIndicator { get; set; }

        /// <summary />
        public DateTime EffectiveDate { get; set; }

        /// <summary />
        public string Email { get; set; }

        /// <summary />
        public Rock.Client.Enums.EmailPreference EmailPreference { get; set; }

        /// <summary />
        public string EmailPreferenceText { get; set; }

        /// <summary />
        public DateTime ExpireDate { get; set; }

        /// <summary />
        public string FirstName { get; set; }

        /// <summary />
        public Guid? ForeignGuid { get; set; }

        /// <summary />
        public string ForeignKey { get; set; }

        /// <summary />
        public Rock.Client.Enums.Gender Gender { get; set; }

        /// <summary />
        public string GenderText { get; set; }

        /// <summary />
        public int? GivingGroupId { get; set; }

        /// <summary />
        public string GivingId { get; set; }

        /// <summary />
        public int? GivingLeaderId { get; set; }

        /// <summary />
        public int? GraduationYear { get; set; }

        /// <summary />
        public string InactiveReasonNote { get; set; }

        /// <summary />
        public bool IsDeceased { get; set; }

        /// <summary />
        public string LastName { get; set; }

        /// <summary />
        public string MaritalStatus { get; set; }

        /// <summary />
        public int? MaritalStatusValueId { get; set; }

        /// <summary />
        public string MiddleName { get; set; }

        /// <summary />
        public string NickName { get; set; }

        /// <summary />
        public int PersonId { get; set; }

        /// <summary />
        public int? PhotoId { get; set; }

        /// <summary />
        public int? PrimaryFamilyId { get; set; }

        /// <summary />
        public int? PrimaryFamilyKey { get; set; }

        /// <summary />
        public string RecordStatus { get; set; }

        /// <summary />
        public DateTime? RecordStatusLastModifiedDateTime { get; set; }

        /// <summary />
        public string RecordStatusReason { get; set; }

        /// <summary />
        public int? RecordStatusReasonValueId { get; set; }

        /// <summary />
        public int? RecordStatusValueId { get; set; }

        /// <summary />
        public string RecordType { get; set; }

        /// <summary />
        public int? RecordTypeValueId { get; set; }

        /// <summary />
        public string ReviewReason { get; set; }

        /// <summary />
        public string ReviewReasonNote { get; set; }

        /// <summary />
        public int? ReviewReasonValueId { get; set; }

        /// <summary />
        public string Suffix { get; set; }

        /// <summary />
        public int? SuffixValueId { get; set; }

        /// <summary />
        public string SystemNote { get; set; }

        /// <summary />
        public string Title { get; set; }

        /// <summary />
        public int? TitleValueId { get; set; }

        /// <summary />
        public int? ViewedCount { get; set; }

        /// <summary />
        public Guid Guid { get; set; }

        /// <summary />
        public int? ForeignId { get; set; }

        /// <summary>
        /// Copies the base properties from a source AnalyticsDimPersonCurrent object
        /// </summary>
        /// <param name="source">The source.</param>
        public void CopyPropertiesFrom( AnalyticsDimPersonCurrent source )
        {
            this.Id = source.Id;
            this.Age = source.Age;
            this.AnniversaryDate = source.AnniversaryDate;
            this.BirthDateKey = source.BirthDateKey;
            this.BirthDay = source.BirthDay;
            this.BirthMonth = source.BirthMonth;
            this.BirthYear = source.BirthYear;
            this.ConnectionStatus = source.ConnectionStatus;
            this.ConnectionStatusValueId = source.ConnectionStatusValueId;
            this.CurrentRowIndicator = source.CurrentRowIndicator;
            this.EffectiveDate = source.EffectiveDate;
            this.Email = source.Email;
            this.EmailPreference = source.EmailPreference;
            this.EmailPreferenceText = source.EmailPreferenceText;
            this.ExpireDate = source.ExpireDate;
            this.FirstName = source.FirstName;
            this.ForeignGuid = source.ForeignGuid;
            this.ForeignKey = source.ForeignKey;
            this.Gender = source.Gender;
            this.GenderText = source.GenderText;
            this.GivingGroupId = source.GivingGroupId;
            this.GivingId = source.GivingId;
            this.GivingLeaderId = source.GivingLeaderId;
            this.GraduationYear = source.GraduationYear;
            this.InactiveReasonNote = source.InactiveReasonNote;
            this.IsDeceased = source.IsDeceased;
            this.LastName = source.LastName;
            this.MaritalStatus = source.MaritalStatus;
            this.MaritalStatusValueId = source.MaritalStatusValueId;
            this.MiddleName = source.MiddleName;
            this.NickName = source.NickName;
            this.PersonId = source.PersonId;
            this.PhotoId = source.PhotoId;
            this.PrimaryFamilyId = source.PrimaryFamilyId;
            this.PrimaryFamilyKey = source.PrimaryFamilyKey;
            this.RecordStatus = source.RecordStatus;
            this.RecordStatusLastModifiedDateTime = source.RecordStatusLastModifiedDateTime;
            this.RecordStatusReason = source.RecordStatusReason;
            this.RecordStatusReasonValueId = source.RecordStatusReasonValueId;
            this.RecordStatusValueId = source.RecordStatusValueId;
            this.RecordType = source.RecordType;
            this.RecordTypeValueId = source.RecordTypeValueId;
            this.ReviewReason = source.ReviewReason;
            this.ReviewReasonNote = source.ReviewReasonNote;
            this.ReviewReasonValueId = source.ReviewReasonValueId;
            this.Suffix = source.Suffix;
            this.SuffixValueId = source.SuffixValueId;
            this.SystemNote = source.SystemNote;
            this.Title = source.Title;
            this.TitleValueId = source.TitleValueId;
            this.ViewedCount = source.ViewedCount;
            this.Guid = source.Guid;
            this.ForeignId = source.ForeignId;

        }
    }

    /// <summary>
    /// Client model for AnalyticsDimPersonCurrent that includes all the fields that are available for GETs. Use this for GETs (use AnalyticsDimPersonCurrentEntity for POST/PUTs)
    /// </summary>
    public partial class AnalyticsDimPersonCurrent : AnalyticsDimPersonCurrentEntity
    {
        /// <summary />
        public AnalyticsSourceDate BirthDateDim { get; set; }

    }
}