﻿#region License

/*
 * Copyright 2002-2012 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;
#if NET_4_0 || SILVERLIGHT_5
using System.Threading.Tasks;
#else
using Spring.Rest.Client;
#endif

namespace Spring.Social.LinkedIn.Api
{
    // See Spring.NET Social LinkedIn: http://www.springframework.net/social-linkedin/

    // Interface specifying a basic set of operations for interacting with LinkedIn.
    public interface ILinkedIn : IApiBinding
    {
#if NET_4_0 || SILVERLIGHT_5
        // Asynchronously retrieves the user's LinkedIn profile Name.
        Task<LinkedInProfile> GetUserProfileAsync();
#else
#if !SILVERLIGHT
        // Retrieves the user's LinkedIn profile Name.
        LinkedInProfile GetUserProfile();
#endif
        // Asynchronously retrieves the user's LinkedIn profile Name.
        RestOperationCanceler GetUserProfileAsync(Action<RestOperationCompletedEventArgs<LinkedInProfile>> operationCompleted);
#endif
    }
}
