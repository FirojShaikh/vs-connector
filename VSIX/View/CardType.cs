//
// Copyright � 2010, 2011 ThoughtWorks, Inc.
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

using System.Collections.Generic;
using ThoughtWorksMingleLib;

namespace ThoughtWorks.VisualStudio
{
    public class CardType
    {
        private readonly MingleCardType _cardType;
        private readonly ViewModel _model;
        private readonly IMingleProject _project;

        /// <summary>
        /// Copnstructs a new card type
        /// </summary>
        private CardType()
        {

        }

        /// <summary>
        /// Constructs a new card type
        /// </summary>
        /// <param name="cardType"></param>
        public CardType(ViewModel model, IMingleProject project,  MingleCardType cardType)
        {
            _cardType = cardType;
            _model = model;
            _project = project;
        }

        /// <summary>
        /// Card type name
        /// </summary>
        public string Name { get { return _cardType.Name; } }

        public SortedList<string, CardProperty> PropertyDefinitions 
        { 
            get
            {
                var properties = new SortedList<string, CardProperty>();
                //_cardType.PropertyDefinitions.ToList().ForEach(pd => properties.Add(pd.Key, new CardProperty(_model, pd.Value)));
                return properties;
            } 
        }
    }
}