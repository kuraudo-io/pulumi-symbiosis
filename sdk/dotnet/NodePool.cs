// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Kuraudo.Symbiosis
{
    /// <summary>
    /// Creates node pools for Kubernetes clusters in Symbiosis.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Symbiosis = Kuraudo.Symbiosis;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var exampleCluster = new Symbiosis.Cluster("exampleCluster", new()
    ///     {
    ///         Region = "germany-1",
    ///     });
    /// 
    ///     var exampleNodePool = new Symbiosis.NodePool("exampleNodePool", new()
    ///     {
    ///         Cluster = exampleCluster.Name,
    ///         NodeType = "general-1",
    ///         Quantity = 6,
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [SymbiosisResourceType("symbiosis:index/nodePool:NodePool")]
    public partial class NodePool : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Name of cluster to create node pool in.
        /// </summary>
        [Output("cluster")]
        public Output<string> Cluster { get; private set; } = null!;

        /// <summary>
        /// Node labels to be applied to the nodes
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, string>?> Labels { get; private set; } = null!;

        /// <summary>
        /// Name of node pool
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Type of nodes for this specific pool, see docs.
        /// </summary>
        [Output("nodeType")]
        public Output<string> NodeType { get; private set; } = null!;

        /// <summary>
        /// Desired number of nodes for specific pool.
        /// </summary>
        [Output("quantity")]
        public Output<int> Quantity { get; private set; } = null!;

        /// <summary>
        /// Node taints to be applied to the nodes
        /// </summary>
        [Output("taints")]
        public Output<ImmutableArray<Outputs.NodePoolTaint>> Taints { get; private set; } = null!;


        /// <summary>
        /// Create a NodePool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NodePool(string name, NodePoolArgs args, CustomResourceOptions? options = null)
            : base("symbiosis:index/nodePool:NodePool", name, args ?? new NodePoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NodePool(string name, Input<string> id, NodePoolState? state = null, CustomResourceOptions? options = null)
            : base("symbiosis:index/nodePool:NodePool", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/kuraudo-io/pulumi-symbiosis/releases/",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NodePool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NodePool Get(string name, Input<string> id, NodePoolState? state = null, CustomResourceOptions? options = null)
        {
            return new NodePool(name, id, state, options);
        }
    }

    public sealed class NodePoolArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of cluster to create node pool in.
        /// </summary>
        [Input("cluster", required: true)]
        public Input<string> Cluster { get; set; } = null!;

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Node labels to be applied to the nodes
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of node pool
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Type of nodes for this specific pool, see docs.
        /// </summary>
        [Input("nodeType", required: true)]
        public Input<string> NodeType { get; set; } = null!;

        /// <summary>
        /// Desired number of nodes for specific pool.
        /// </summary>
        [Input("quantity", required: true)]
        public Input<int> Quantity { get; set; } = null!;

        [Input("taints")]
        private InputList<Inputs.NodePoolTaintArgs>? _taints;

        /// <summary>
        /// Node taints to be applied to the nodes
        /// </summary>
        public InputList<Inputs.NodePoolTaintArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.NodePoolTaintArgs>());
            set => _taints = value;
        }

        public NodePoolArgs()
        {
        }
        public static new NodePoolArgs Empty => new NodePoolArgs();
    }

    public sealed class NodePoolState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of cluster to create node pool in.
        /// </summary>
        [Input("cluster")]
        public Input<string>? Cluster { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;

        /// <summary>
        /// Node labels to be applied to the nodes
        /// </summary>
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        /// <summary>
        /// Name of node pool
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Type of nodes for this specific pool, see docs.
        /// </summary>
        [Input("nodeType")]
        public Input<string>? NodeType { get; set; }

        /// <summary>
        /// Desired number of nodes for specific pool.
        /// </summary>
        [Input("quantity")]
        public Input<int>? Quantity { get; set; }

        [Input("taints")]
        private InputList<Inputs.NodePoolTaintGetArgs>? _taints;

        /// <summary>
        /// Node taints to be applied to the nodes
        /// </summary>
        public InputList<Inputs.NodePoolTaintGetArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.NodePoolTaintGetArgs>());
            set => _taints = value;
        }

        public NodePoolState()
        {
        }
        public static new NodePoolState Empty => new NodePoolState();
    }
}
