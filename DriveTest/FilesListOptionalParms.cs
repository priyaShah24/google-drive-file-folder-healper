﻿using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.Text;

namespace DriveTest
{
    public class FilesListOptionalParms
    {
        /// 

        /// The source of files to list.
        /// 
        public string Corpus { get; set; }
        /// 

        /// A comma-separated list of sort keys. Valid keys are 'createdTime', 'folder', 'modifiedByMeTime', 'modifiedTime', 'name', 'quotaBytesUsed', 'recency', 'sharedWithMeTime', 'starred', and 'viewedByMeTime'. Each key sorts ascending by default, but may be reversed with the 'desc' modifier. Example usage: ?orderBy=folder,modifiedTime desc,name. Please note that there is a current limitation for users with approximately one million files in which the requested sort order is ignored.
        /// 
        public string OrderBy { get; set; }
        /// 

        /// The maximum number of files to return per page.
        /// 
        public int? PageSize { get; set; }
        /// 

        /// The token for continuing a previous list request on the next page. This should be set to the value of 'nextPageToken' from the previous response.
        /// 
        public string PageToken { get; set; }
        /// 

        /// A query for filtering the file results. See the "Search for Files" guide for supported syntax.
        /// 
        public string Q { get; set; }
        /// 

        /// A comma-separated list of spaces to query within the corpus. Supported values are 'drive', 'appDataFolder' and 'photos'.
        /// 
        public string Spaces { get; set; }
        /// 

        /// Selector specifying a subset of fields to include in the response.
        /// 
        public string fields { get; set; }
        /// 

        /// Alternative to userIp.
        /// 
        public string quotaUser { get; set; }
        /// 

        /// IP address of the end user for whom the API call is being made.
        /// 
        public string userIp { get; set; }

        public string DriveId { get; set; }
    }
}
