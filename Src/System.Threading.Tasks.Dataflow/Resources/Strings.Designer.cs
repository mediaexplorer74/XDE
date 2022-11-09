﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.0
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Threading.Tasks.Dataflow.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Threading.Tasks.Dataflow.Resources.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 BoundedCapacity must be Unbounded or -1 for this dataflow block. 的本地化字符串。
        /// </summary>
        internal static string Argument_BoundedCapacityNotSupported {
            get {
                return ResourceManager.GetString("Argument_BoundedCapacityNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The argument must be false if no source from which to consume is specified. 的本地化字符串。
        /// </summary>
        internal static string Argument_CantConsumeFromANullSource {
            get {
                return ResourceManager.GetString("Argument_CantConsumeFromANullSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The DataflowMessageHeader instance does not represent a valid message header. 的本地化字符串。
        /// </summary>
        internal static string Argument_InvalidMessageHeader {
            get {
                return ResourceManager.GetString("Argument_InvalidMessageHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 To construct a DataflowMessageHeader instance, either pass a non-zero value or use the parameterless constructor. 的本地化字符串。
        /// </summary>
        internal static string Argument_InvalidMessageId {
            get {
                return ResourceManager.GetString("Argument_InvalidMessageId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This block must only be used with the source from which it was created. 的本地化字符串。
        /// </summary>
        internal static string Argument_InvalidSourceForFilteredLink {
            get {
                return ResourceManager.GetString("Argument_InvalidSourceForFilteredLink", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Greedy must be true for this dataflow block. 的本地化字符串。
        /// </summary>
        internal static string Argument_NonGreedyNotSupported {
            get {
                return ResourceManager.GetString("Argument_NonGreedyNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Number must be no greater than the value specified in BoundedCapacity. 的本地化字符串。
        /// </summary>
        internal static string ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Number must be positive. 的本地化字符串。
        /// </summary>
        internal static string ArgumentOutOfRange_GenericPositive {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_GenericPositive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Number must be either non-negative and less than or equal to Int32.MaxValue or -1 的本地化字符串。
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegOrNegative1 {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegOrNegative1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Object is not a array with the same initialization state as the array to compare it to. 的本地化字符串。
        /// </summary>
        internal static string ArrayInitializedStateNotEqual {
            get {
                return ResourceManager.GetString("ArrayInitializedStateNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Object is not a array with the same number of elements as the array to compare it to. 的本地化字符串。
        /// </summary>
        internal static string ArrayLengthsNotEqual {
            get {
                return ResourceManager.GetString("ArrayLengthsNotEqual", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Cannot find the old value 的本地化字符串。
        /// </summary>
        internal static string CannotFindOldValue {
            get {
                return ResourceManager.GetString("CannotFindOldValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Capacity was less than the current Count of elements. 的本地化字符串。
        /// </summary>
        internal static string CapacityMustBeGreaterThanOrEqualToCount {
            get {
                return ResourceManager.GetString("CapacityMustBeGreaterThanOrEqualToCount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 MoveToImmutable can only be performed when Count equals Capacity. 的本地化字符串。
        /// </summary>
        internal static string CapacityMustEqualCountOnMove {
            get {
                return ResourceManager.GetString("CapacityMustEqualCountOnMove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Collection was modified; enumeration operation may not execute. 的本地化字符串。
        /// </summary>
        internal static string CollectionModifiedDuringEnumeration {
            get {
                return ResourceManager.GetString("CollectionModifiedDuringEnumeration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The SyncRoot property may not be used for the synchronization of concurrent collections. 的本地化字符串。
        /// </summary>
        internal static string ConcurrentCollection_SyncRoot_NotSupported {
            get {
                return ResourceManager.GetString("ConcurrentCollection_SyncRoot_NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 An element with the same key but a different value already exists. Key: {0} 的本地化字符串。
        /// </summary>
        internal static string DuplicateKey {
            get {
                return ResourceManager.GetString("DuplicateKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Block {0} completed as {1}. {2} 的本地化字符串。
        /// </summary>
        internal static string event_DataflowBlockCompleted {
            get {
                return ResourceManager.GetString("event_DataflowBlockCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Block of type {0} instantiated with Id {1}. 的本地化字符串。
        /// </summary>
        internal static string event_DataflowBlockCreated {
            get {
                return ResourceManager.GetString("event_DataflowBlockCreated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Source {0} linked to target {1}. 的本地化字符串。
        /// </summary>
        internal static string event_DataflowBlockLinking {
            get {
                return ResourceManager.GetString("event_DataflowBlockLinking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Source {0} unlinked from target {1}. 的本地化字符串。
        /// </summary>
        internal static string event_DataflowBlockUnlinking {
            get {
                return ResourceManager.GetString("event_DataflowBlockUnlinking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {1} task launched from block {0} with {2} message(s) pending. 的本地化字符串。
        /// </summary>
        internal static string event_TaskLaunchedForMessageHandling {
            get {
                return ResourceManager.GetString("event_TaskLaunchedForMessageHandling", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This operation does not apply to an empty instance. 的本地化字符串。
        /// </summary>
        internal static string InvalidEmptyOperation {
            get {
                return ResourceManager.GetString("InvalidEmptyOperation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The source completed without providing data to receive. 的本地化字符串。
        /// </summary>
        internal static string InvalidOperation_DataNotAvailableForReceive {
            get {
                return ResourceManager.GetString("InvalidOperation_DataNotAvailableForReceive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The target block failed to consume a message it had successfully reserved. 的本地化字符串。
        /// </summary>
        internal static string InvalidOperation_FailedToConsumeReservedMessage {
            get {
                return ResourceManager.GetString("InvalidOperation_FailedToConsumeReservedMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The target does not have the message reserved. 的本地化字符串。
        /// </summary>
        internal static string InvalidOperation_MessageNotReservedByTarget {
            get {
                return ResourceManager.GetString("InvalidOperation_MessageNotReservedByTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This operation cannot be performed on a default instance of ImmutableArray&lt;T&gt;.  Consider initializing the array, or checking the ImmutableArray&lt;T&gt;.IsDefault property. 的本地化字符串。
        /// </summary>
        internal static string InvalidOperationOnDefaultArray {
            get {
                return ResourceManager.GetString("InvalidOperationOnDefaultArray", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This member is not supported on this dataflow block. The block is intended for a specific purpose that does not utilize this member. 的本地化字符串。
        /// </summary>
        internal static string NotSupported_MemberNotNeeded {
            get {
                return ResourceManager.GetString("NotSupported_MemberNotNeeded", resourceCulture);
            }
        }
    }
}
