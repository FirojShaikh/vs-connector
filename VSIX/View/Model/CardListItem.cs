﻿#region Copyright © 2010, 2011,2012, 2013 ThoughtWorks, Inc.

//
// Licensed under the Apache License, Version 2.0 (the "License"); 
// you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at:
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS, 
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
// See the License for the specific language governing permissions and 
// limitations under the License.
//

#endregion

namespace ThoughtWorks.VisualStudio
{
    /// <summary>
    /// Describes a card's name, number and type
    /// </summary>
    public class CardListItem
    {
        /// <summary>
        /// Card name
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Card number
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Card type name
        /// </summary>
        public string TypeName { get; set; }
    }
}