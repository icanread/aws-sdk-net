/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Specifies the actions performed and the next state entered when a <code>condition</code>
    /// evaluates to TRUE.
    /// </summary>
    public partial class TransitionEvent
    {
        private List<Action> _actions = new List<Action>();
        private string _condition;
        private string _eventName;
        private string _nextState;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to be performed.
        /// </para>
        /// </summary>
        public List<Action> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// [Required] A Boolean expression that when TRUE causes the actions to be performed
        /// and the <code>nextState</code> to be entered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Condition
        {
            get { return this._condition; }
            set { this._condition = value; }
        }

        // Check to see if Condition property is set
        internal bool IsSetCondition()
        {
            return this._condition != null;
        }

        /// <summary>
        /// Gets and sets the property EventName. 
        /// <para>
        /// The name of the transition event.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string EventName
        {
            get { return this._eventName; }
            set { this._eventName = value; }
        }

        // Check to see if EventName property is set
        internal bool IsSetEventName()
        {
            return this._eventName != null;
        }

        /// <summary>
        /// Gets and sets the property NextState. 
        /// <para>
        /// The next state to enter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NextState
        {
            get { return this._nextState; }
            set { this._nextState = value; }
        }

        // Check to see if NextState property is set
        internal bool IsSetNextState()
        {
            return this._nextState != null;
        }

    }
}