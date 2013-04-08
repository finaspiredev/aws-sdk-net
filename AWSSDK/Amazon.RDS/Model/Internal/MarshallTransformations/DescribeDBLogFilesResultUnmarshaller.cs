/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Generic;

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeDBLogFilesResult Unmarshaller
     /// </summary>
    internal class DescribeDBLogFilesResultUnmarshaller : IUnmarshaller<DescribeDBLogFilesResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeDBLogFilesResult, JsonUnmarshallerContext> 
    {
        public DescribeDBLogFilesResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeDBLogFilesResult describeDBLogFilesResult = new DescribeDBLogFilesResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("DescribeDBLogFiles/DescribeDBLogFilesDetails", targetDepth))
                    {
                        describeDBLogFilesResult.DescribeDBLogFiles.Add(DescribeDBLogFilesDetailsUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    } 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeDBLogFilesResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeDBLogFilesResult;
                }
            }
                        


            return describeDBLogFilesResult;
        }

        public DescribeDBLogFilesResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeDBLogFilesResultUnmarshaller instance;

        public static DescribeDBLogFilesResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeDBLogFilesResultUnmarshaller();

            return instance;
        }
    }
}
    
