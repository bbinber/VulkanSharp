/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;

namespace Vulkan.Interop
{
	internal struct PhysicalDeviceProperties
	{
		internal UInt32 ApiVersion;
		internal UInt32 DriverVersion;
		internal UInt32 VendorID;
		internal UInt32 DeviceID;
		internal PhysicalDeviceType DeviceType;
		internal unsafe fixed byte DeviceName[256];
		internal Byte PipelineCacheUUID;
		internal IntPtr Limits;
		internal PhysicalDeviceSparseProperties SparseProperties;
	}

	internal struct ExtensionProperties
	{
		internal unsafe fixed byte ExtensionName[256];
		internal UInt32 SpecVersion;
	}

	internal struct LayerProperties
	{
		internal unsafe fixed byte LayerName[256];
		internal UInt32 SpecVersion;
		internal UInt32 ImplementationVersion;
		internal unsafe fixed byte Description[256];
	}

	internal struct ApplicationInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal IntPtr ApplicationName;
		internal UInt32 ApplicationVersion;
		internal IntPtr EngineName;
		internal UInt32 EngineVersion;
		internal UInt32 ApiVersion;
	}

	internal struct AllocationCallbacks
	{
		internal IntPtr UserData;
		internal IntPtr PfnAllocation;
		internal IntPtr PfnReallocation;
		internal IntPtr PfnFree;
		internal IntPtr PfnInternalAllocation;
		internal IntPtr PfnInternalFree;
	}

	internal struct DeviceQueueCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueFamilyIndex;
		internal UInt32 QueueCount;
		internal IntPtr QueuePriorities;
	}

	internal struct DeviceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueCreateInfoCount;
		internal IntPtr QueueCreateInfos;
		internal UInt32 EnabledLayerCount;
		internal IntPtr EnabledLayerNames;
		internal UInt32 EnabledExtensionCount;
		internal IntPtr EnabledExtensionNames;
		internal PhysicalDeviceFeatures EnabledFeatures;
	}

	internal struct InstanceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr ApplicationInfo;
		internal UInt32 EnabledLayerCount;
		internal IntPtr EnabledLayerNames;
		internal UInt32 EnabledExtensionCount;
		internal IntPtr EnabledExtensionNames;
	}

	internal struct PhysicalDeviceMemoryProperties
	{
		internal UInt32 MemoryTypeCount;
		internal MemoryType MemoryTypes;
		internal UInt32 MemoryHeapCount;
		internal MemoryHeap MemoryHeaps;
	}

	internal struct MemoryAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal DeviceSize AllocationSize;
		internal UInt32 MemoryTypeIndex;
	}

	internal struct MappedMemoryRange
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 Memory;
		internal DeviceSize Offset;
		internal DeviceSize Size;
	}

	internal struct WriteDescriptorSet
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 DstSet;
		internal UInt32 DstBinding;
		internal UInt32 DstArrayElement;
		internal UInt32 DescriptorCount;
		internal DescriptorType DescriptorType;
		internal DescriptorImageInfo ImageInfo;
		internal DescriptorBufferInfo BufferInfo;
		internal UInt64 TexelBufferView;
	}

	internal struct CopyDescriptorSet
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 SrcSet;
		internal UInt32 SrcBinding;
		internal UInt32 SrcArrayElement;
		internal UInt64 DstSet;
		internal UInt32 DstBinding;
		internal UInt32 DstArrayElement;
		internal UInt32 DescriptorCount;
	}

	internal struct BufferCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal DeviceSize Size;
		internal UInt32 Usage;
		internal SharingMode SharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal IntPtr QueueFamilyIndices;
	}

	internal struct BufferViewCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt64 Buffer;
		internal Format Format;
		internal DeviceSize Offset;
		internal DeviceSize Range;
	}

	internal struct MemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
	}

	internal struct BufferMemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
		internal UInt32 SrcQueueFamilyIndex;
		internal UInt32 DstQueueFamilyIndex;
		internal UInt64 Buffer;
		internal DeviceSize Offset;
		internal DeviceSize Size;
	}

	internal struct ImageMemoryBarrier
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 SrcAccessMask;
		internal UInt32 DstAccessMask;
		internal ImageLayout OldLayout;
		internal ImageLayout NewLayout;
		internal UInt32 SrcQueueFamilyIndex;
		internal UInt32 DstQueueFamilyIndex;
		internal UInt64 Image;
		internal ImageSubresourceRange SubresourceRange;
	}

	internal struct ImageCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal ImageType ImageType;
		internal Format Format;
		internal Extent3D Extent;
		internal UInt32 MipLevels;
		internal UInt32 ArrayLayers;
		internal UInt32 Samples;
		internal ImageTiling Tiling;
		internal UInt32 Usage;
		internal SharingMode SharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal IntPtr QueueFamilyIndices;
		internal ImageLayout InitialLayout;
	}

	internal struct ImageViewCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt64 Image;
		internal ImageViewType ViewType;
		internal Format Format;
		internal ComponentMapping Components;
		internal ImageSubresourceRange SubresourceRange;
	}

	internal struct SparseBufferMemoryBindInfo
	{
		internal UInt64 Buffer;
		internal UInt32 BindCount;
		internal SparseMemoryBind Binds;
	}

	internal struct SparseImageOpaqueMemoryBindInfo
	{
		internal UInt64 Image;
		internal UInt32 BindCount;
		internal SparseMemoryBind Binds;
	}

	internal struct SparseImageMemoryBindInfo
	{
		internal UInt64 Image;
		internal UInt32 BindCount;
		internal SparseImageMemoryBind Binds;
	}

	internal struct BindSparseInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal UInt64 WaitSemaphores;
		internal UInt32 BufferBindCount;
		internal IntPtr BufferBinds;
		internal UInt32 ImageOpaqueBindCount;
		internal IntPtr ImageOpaqueBinds;
		internal UInt32 ImageBindCount;
		internal IntPtr ImageBinds;
		internal UInt32 SignalSemaphoreCount;
		internal UInt64 SignalSemaphores;
	}

	internal struct ImageBlit
	{
		internal ImageSubresourceLayers SrcSubresource;
		internal Offset3D SrcOffsets;
		internal ImageSubresourceLayers DstSubresource;
		internal Offset3D DstOffsets;
	}

	internal struct ShaderModuleCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UIntPtr CodeSize;
		internal IntPtr Code;
	}

	internal struct DescriptorSetLayoutBinding
	{
		internal UInt32 Binding;
		internal DescriptorType DescriptorType;
		internal UInt32 DescriptorCount;
		internal UInt32 StageFlags;
		internal UInt64 ImmutableSamplers;
	}

	internal struct DescriptorSetLayoutCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 BindingCount;
		internal IntPtr Bindings;
	}

	internal struct DescriptorPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 MaxSets;
		internal UInt32 PoolSizeCount;
		internal DescriptorPoolSize PoolSizes;
	}

	internal struct DescriptorSetAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 DescriptorPool;
		internal UInt32 DescriptorSetCount;
		internal UInt64 SetLayouts;
	}

	internal struct SpecializationInfo
	{
		internal UInt32 MapEntryCount;
		internal SpecializationMapEntry MapEntries;
		internal UIntPtr DataSize;
		internal IntPtr Data;
	}

	internal struct PipelineShaderStageCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 Stage;
		internal UInt64 Module;
		internal IntPtr Name;
		internal IntPtr SpecializationInfo;
	}

	internal struct ComputePipelineCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr Stage;
		internal UInt64 Layout;
		internal UInt64 BasePipelineHandle;
		internal Int32 BasePipelineIndex;
	}

	internal struct PipelineVertexInputStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 VertexBindingDescriptionCount;
		internal VertexInputBindingDescription VertexBindingDescriptions;
		internal UInt32 VertexAttributeDescriptionCount;
		internal VertexInputAttributeDescription VertexAttributeDescriptions;
	}

	internal struct PipelineInputAssemblyStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal PrimitiveTopology Topology;
		internal Bool32 PrimitiveRestartEnable;
	}

	internal struct PipelineTessellationStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 PatchControlPoints;
	}

	internal struct PipelineViewportStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 ViewportCount;
		internal Viewport Viewports;
		internal UInt32 ScissorCount;
		internal Rect2D Scissors;
	}

	internal struct PipelineRasterizationStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 DepthClampEnable;
		internal Bool32 RasterizerDiscardEnable;
		internal PolygonMode PolygonMode;
		internal UInt32 CullMode;
		internal FrontFace FrontFace;
		internal Bool32 DepthBiasEnable;
		internal float DepthBiasConstantFactor;
		internal float DepthBiasClamp;
		internal float DepthBiasSlopeFactor;
		internal float LineWidth;
	}

	internal struct PipelineMultisampleStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 RasterizationSamples;
		internal Bool32 SampleShadingEnable;
		internal float MinSampleShading;
		internal UInt32 SampleMask;
		internal Bool32 AlphaToCoverageEnable;
		internal Bool32 AlphaToOneEnable;
	}

	internal struct PipelineColorBlendStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 LogicOpEnable;
		internal LogicOp LogicOp;
		internal UInt32 AttachmentCount;
		internal PipelineColorBlendAttachmentState Attachments;
		internal float BlendConstants;
	}

	internal struct PipelineDynamicStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 DynamicStateCount;
		internal DynamicState DynamicStates;
	}

	internal struct PipelineDepthStencilStateCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Bool32 DepthTestEnable;
		internal Bool32 DepthWriteEnable;
		internal CompareOp DepthCompareOp;
		internal Bool32 DepthBoundsTestEnable;
		internal Bool32 StencilTestEnable;
		internal StencilOpState Front;
		internal StencilOpState Back;
		internal float MinDepthBounds;
		internal float MaxDepthBounds;
	}

	internal struct GraphicsPipelineCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 StageCount;
		internal IntPtr Stages;
		internal IntPtr VertexInputState;
		internal IntPtr InputAssemblyState;
		internal IntPtr TessellationState;
		internal IntPtr ViewportState;
		internal IntPtr RasterizationState;
		internal IntPtr MultisampleState;
		internal IntPtr DepthStencilState;
		internal IntPtr ColorBlendState;
		internal IntPtr DynamicState;
		internal UInt64 Layout;
		internal UInt64 RenderPass;
		internal UInt32 Subpass;
		internal UInt64 BasePipelineHandle;
		internal Int32 BasePipelineIndex;
	}

	internal struct PipelineCacheCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UIntPtr InitialDataSize;
		internal IntPtr InitialData;
	}

	internal struct PipelineLayoutCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 SetLayoutCount;
		internal UInt64 SetLayouts;
		internal UInt32 PushConstantRangeCount;
		internal PushConstantRange PushConstantRanges;
	}

	internal struct SamplerCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal Filter MagFilter;
		internal Filter MinFilter;
		internal SamplerMipmapMode MipmapMode;
		internal SamplerAddressMode AddressModeU;
		internal SamplerAddressMode AddressModeV;
		internal SamplerAddressMode AddressModeW;
		internal float MipLodBias;
		internal Bool32 AnisotropyEnable;
		internal float MaxAnisotropy;
		internal Bool32 CompareEnable;
		internal CompareOp CompareOp;
		internal float MinLod;
		internal float MaxLod;
		internal BorderColor BorderColor;
		internal Bool32 UnnormalizedCoordinates;
	}

	internal struct CommandPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 QueueFamilyIndex;
	}

	internal struct CommandBufferAllocateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 CommandPool;
		internal CommandBufferLevel Level;
		internal UInt32 CommandBufferCount;
	}

	internal struct CommandBufferInheritanceInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 RenderPass;
		internal UInt32 Subpass;
		internal UInt64 Framebuffer;
		internal Bool32 OcclusionQueryEnable;
		internal UInt32 QueryFlags;
		internal UInt32 PipelineStatistics;
	}

	internal struct CommandBufferBeginInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal IntPtr InheritanceInfo;
	}

	internal struct RenderPassBeginInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt64 RenderPass;
		internal UInt64 Framebuffer;
		internal Rect2D RenderArea;
		internal UInt32 ClearValueCount;
		internal ClearValue ClearValues;
	}

	internal struct SubpassDescription
	{
		internal UInt32 Flags;
		internal PipelineBindPoint PipelineBindPoint;
		internal UInt32 InputAttachmentCount;
		internal AttachmentReference InputAttachments;
		internal UInt32 ColorAttachmentCount;
		internal AttachmentReference ColorAttachments;
		internal AttachmentReference ResolveAttachments;
		internal AttachmentReference DepthStencilAttachment;
		internal UInt32 PreserveAttachmentCount;
		internal IntPtr PreserveAttachments;
	}

	internal struct RenderPassCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt32 AttachmentCount;
		internal AttachmentDescription Attachments;
		internal UInt32 SubpassCount;
		internal IntPtr Subpasses;
		internal UInt32 DependencyCount;
		internal SubpassDependency Dependencies;
	}

	internal struct EventCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct FenceCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct PhysicalDeviceLimits
	{
		internal UInt32 MaxImageDimension1D;
		internal UInt32 MaxImageDimension2D;
		internal UInt32 MaxImageDimension3D;
		internal UInt32 MaxImageDimensionCube;
		internal UInt32 MaxImageArrayLayers;
		internal UInt32 MaxTexelBufferElements;
		internal UInt32 MaxUniformBufferRange;
		internal UInt32 MaxStorageBufferRange;
		internal UInt32 MaxPushConstantsSize;
		internal UInt32 MaxMemoryAllocationCount;
		internal UInt32 MaxSamplerAllocationCount;
		internal DeviceSize BufferImageGranularity;
		internal DeviceSize SparseAddressSpaceSize;
		internal UInt32 MaxBoundDescriptorSets;
		internal UInt32 MaxPerStageDescriptorSamplers;
		internal UInt32 MaxPerStageDescriptorUniformBuffers;
		internal UInt32 MaxPerStageDescriptorStorageBuffers;
		internal UInt32 MaxPerStageDescriptorSampledImages;
		internal UInt32 MaxPerStageDescriptorStorageImages;
		internal UInt32 MaxPerStageDescriptorInputAttachments;
		internal UInt32 MaxPerStageResources;
		internal UInt32 MaxDescriptorSetSamplers;
		internal UInt32 MaxDescriptorSetUniformBuffers;
		internal UInt32 MaxDescriptorSetUniformBuffersDynamic;
		internal UInt32 MaxDescriptorSetStorageBuffers;
		internal UInt32 MaxDescriptorSetStorageBuffersDynamic;
		internal UInt32 MaxDescriptorSetSampledImages;
		internal UInt32 MaxDescriptorSetStorageImages;
		internal UInt32 MaxDescriptorSetInputAttachments;
		internal UInt32 MaxVertexInputAttributes;
		internal UInt32 MaxVertexInputBindings;
		internal UInt32 MaxVertexInputAttributeOffset;
		internal UInt32 MaxVertexInputBindingStride;
		internal UInt32 MaxVertexOutputComponents;
		internal UInt32 MaxTessellationGenerationLevel;
		internal UInt32 MaxTessellationPatchSize;
		internal UInt32 MaxTessellationControlPerVertexInputComponents;
		internal UInt32 MaxTessellationControlPerVertexOutputComponents;
		internal UInt32 MaxTessellationControlPerPatchOutputComponents;
		internal UInt32 MaxTessellationControlTotalOutputComponents;
		internal UInt32 MaxTessellationEvaluationInputComponents;
		internal UInt32 MaxTessellationEvaluationOutputComponents;
		internal UInt32 MaxGeometryShaderInvocations;
		internal UInt32 MaxGeometryInputComponents;
		internal UInt32 MaxGeometryOutputComponents;
		internal UInt32 MaxGeometryOutputVertices;
		internal UInt32 MaxGeometryTotalOutputComponents;
		internal UInt32 MaxFragmentInputComponents;
		internal UInt32 MaxFragmentOutputAttachments;
		internal UInt32 MaxFragmentDualSrcAttachments;
		internal UInt32 MaxFragmentCombinedOutputResources;
		internal UInt32 MaxComputeSharedMemorySize;
		internal UInt32 MaxComputeWorkGroupCount;
		internal UInt32 MaxComputeWorkGroupInvocations;
		internal UInt32 MaxComputeWorkGroupSize;
		internal UInt32 SubPixelPrecisionBits;
		internal UInt32 SubTexelPrecisionBits;
		internal UInt32 MipmapPrecisionBits;
		internal UInt32 MaxDrawIndexedIndexValue;
		internal UInt32 MaxDrawIndirectCount;
		internal float MaxSamplerLodBias;
		internal float MaxSamplerAnisotropy;
		internal UInt32 MaxViewports;
		internal UInt32 MaxViewportDimensions;
		internal float ViewportBoundsRange;
		internal UInt32 ViewportSubPixelBits;
		internal UIntPtr MinMemoryMapAlignment;
		internal DeviceSize MinTexelBufferOffsetAlignment;
		internal DeviceSize MinUniformBufferOffsetAlignment;
		internal DeviceSize MinStorageBufferOffsetAlignment;
		internal Int32 MinTexelOffset;
		internal UInt32 MaxTexelOffset;
		internal Int32 MinTexelGatherOffset;
		internal UInt32 MaxTexelGatherOffset;
		internal float MinInterpolationOffset;
		internal float MaxInterpolationOffset;
		internal UInt32 SubPixelInterpolationOffsetBits;
		internal UInt32 MaxFramebufferWidth;
		internal UInt32 MaxFramebufferHeight;
		internal UInt32 MaxFramebufferLayers;
		internal UInt32 FramebufferColorSampleCounts;
		internal UInt32 FramebufferDepthSampleCounts;
		internal UInt32 FramebufferStencilSampleCounts;
		internal UInt32 FramebufferNoAttachmentsSampleCounts;
		internal UInt32 MaxColorAttachments;
		internal UInt32 SampledImageColorSampleCounts;
		internal UInt32 SampledImageIntegerSampleCounts;
		internal UInt32 SampledImageDepthSampleCounts;
		internal UInt32 SampledImageStencilSampleCounts;
		internal UInt32 StorageImageSampleCounts;
		internal UInt32 MaxSampleMaskWords;
		internal Bool32 TimestampComputeAndGraphics;
		internal float TimestampPeriod;
		internal UInt32 MaxClipDistances;
		internal UInt32 MaxCullDistances;
		internal UInt32 MaxCombinedClipAndCullDistances;
		internal UInt32 DiscreteQueuePriorities;
		internal float PointSizeRange;
		internal float LineWidthRange;
		internal float PointSizeGranularity;
		internal float LineWidthGranularity;
		internal Bool32 StrictLines;
		internal Bool32 StandardSampleLocations;
		internal DeviceSize OptimalBufferCopyOffsetAlignment;
		internal DeviceSize OptimalBufferCopyRowPitchAlignment;
		internal DeviceSize NonCoherentAtomSize;
	}

	internal struct SemaphoreCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
	}

	internal struct QueryPoolCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal QueryType QueryType;
		internal UInt32 QueryCount;
		internal UInt32 PipelineStatistics;
	}

	internal struct FramebufferCreateInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt64 RenderPass;
		internal UInt32 AttachmentCount;
		internal UInt64 Attachments;
		internal UInt32 Width;
		internal UInt32 Height;
		internal UInt32 Layers;
	}

	internal struct SubmitInfo
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal UInt64 WaitSemaphores;
		internal UInt32 WaitDstStageMask;
		internal UInt32 CommandBufferCount;
		internal IntPtr CommandBuffers;
		internal UInt32 SignalSemaphoreCount;
		internal UInt64 SignalSemaphores;
	}

	internal struct DisplayPropertiesKhr
	{
		internal UInt64 Display;
		internal IntPtr DisplayName;
		internal Extent2D PhysicalDimensions;
		internal Extent2D PhysicalResolution;
		internal SurfaceTransformFlagsKhr SupportedTransforms;
		internal Bool32 PlaneReorderPossible;
		internal Bool32 PersistentContent;
	}

	internal struct DisplayModeCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal DisplayModeParametersKhr Parameters;
	}

	internal struct DisplaySurfaceCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt64 DisplayMode;
		internal UInt32 PlaneIndex;
		internal UInt32 PlaneStackIndex;
		internal SurfaceTransformFlagsKhr Transform;
		internal float GlobalAlpha;
		internal DisplayPlaneAlphaFlagsKhr AlphaMode;
		internal Extent2D ImageExtent;
	}

	internal struct DisplayPresentInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal Rect2D SrcRect;
		internal Rect2D DstRect;
		internal Bool32 Persistent;
	}

	internal struct SwapchainCreateInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 Flags;
		internal UInt64 Surface;
		internal UInt32 MinImageCount;
		internal Format ImageFormat;
		internal ColorSpaceKhr ImageColorSpace;
		internal Extent2D ImageExtent;
		internal UInt32 ImageArrayLayers;
		internal UInt32 ImageUsage;
		internal SharingMode ImageSharingMode;
		internal UInt32 QueueFamilyIndexCount;
		internal IntPtr QueueFamilyIndices;
		internal SurfaceTransformFlagsKhr PreTransform;
		internal CompositeAlphaFlagsKhr CompositeAlpha;
		internal PresentModeKhr PresentMode;
		internal Bool32 Clipped;
		internal UInt64 OldSwapchain;
	}

	internal struct PresentInfoKhr
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal UInt32 WaitSemaphoreCount;
		internal UInt64 WaitSemaphores;
		internal UInt32 SwapchainCount;
		internal UInt64 Swapchains;
		internal IntPtr ImageIndices;
		internal Result Results;
	}

	internal struct DebugReportCallbackCreateInfoExt
	{
		internal StructureType SType;
		internal IntPtr Next;
		internal DebugReportFlagsExt Flags;
		internal IntPtr PfnCallback;
		internal IntPtr UserData;
	}
}
