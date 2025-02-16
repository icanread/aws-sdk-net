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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAF.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRuleGroup operation.
    /// Creates a <code>RuleGroup</code>. A rule group is a collection of predefined rules
    /// that you add to a web ACL. You use <a>UpdateRuleGroup</a> to add rules to the rule
    /// group.
    /// 
    ///  
    /// <para>
    /// Rule groups are subject to the following limits:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Three rule groups per account. You can request an increase to this limit by contacting
    /// customer support.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// One rule group per web ACL.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Ten rules per rule group.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how to use the AWS WAF API to allow or block HTTP requests,
    /// see the <a href="https://docs.aws.amazon.com/waf/latest/developerguide/">AWS WAF Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRuleGroupRequest : AmazonWAFRequest
    {
        private string _changeToken;
        private string _metricName;
        private string _name;

        /// <summary>
        /// Gets and sets the property ChangeToken. 
        /// <para>
        /// The value returned by the most recent call to <a>GetChangeToken</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ChangeToken
        {
            get { return this._changeToken; }
            set { this._changeToken = value; }
        }

        // Check to see if ChangeToken property is set
        internal bool IsSetChangeToken()
        {
            return this._changeToken != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A friendly name or description for the metrics for this <code>RuleGroup</code>. The
        /// name can contain only alphanumeric characters (A-Z, a-z, 0-9), with maximum length
        /// 128 and minimum length one. It can't contain whitespace or metric names reserved for
        /// AWS WAF, including "All" and "Default_Action." You can't change the name of the metric
        /// after you create the <code>RuleGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name or description of the <a>RuleGroup</a>. You can't change <code>Name</code>
        /// after you create a <code>RuleGroup</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}