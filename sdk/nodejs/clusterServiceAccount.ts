// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * Manages Kubernetes clusters service accounts.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pulumi_symbiosis from "@kuraudo/pulumi-symbiosis";
 *
 * const example = new symbiosis.ClusterServiceAccount("example", {clusterName: symbiosis_cluster.example.name});
 * ```
 */
export class ClusterServiceAccount extends pulumi.CustomResource {
    /**
     * Get an existing ClusterServiceAccount resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClusterServiceAccountState, opts?: pulumi.CustomResourceOptions): ClusterServiceAccount {
        return new ClusterServiceAccount(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'symbiosis:index/clusterServiceAccount:ClusterServiceAccount';

    /**
     * Returns true if the given object is an instance of ClusterServiceAccount.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ClusterServiceAccount {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ClusterServiceAccount.__pulumiType;
    }

    /**
     * Cluster CA certificate
     */
    public /*out*/ readonly clusterCaCertificate!: pulumi.Output<string>;
    /**
     * Cluster name. Changing the name forces re-creation.
     */
    public readonly clusterName!: pulumi.Output<string>;
    /**
     * Service account token
     */
    public /*out*/ readonly token!: pulumi.Output<string>;

    /**
     * Create a ClusterServiceAccount resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterServiceAccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ClusterServiceAccountArgs | ClusterServiceAccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ClusterServiceAccountState | undefined;
            resourceInputs["clusterCaCertificate"] = state ? state.clusterCaCertificate : undefined;
            resourceInputs["clusterName"] = state ? state.clusterName : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
        } else {
            const args = argsOrState as ClusterServiceAccountArgs | undefined;
            if ((!args || args.clusterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterName'");
            }
            resourceInputs["clusterName"] = args ? args.clusterName : undefined;
            resourceInputs["clusterCaCertificate"] = undefined /*out*/;
            resourceInputs["token"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ClusterServiceAccount.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ClusterServiceAccount resources.
 */
export interface ClusterServiceAccountState {
    /**
     * Cluster CA certificate
     */
    clusterCaCertificate?: pulumi.Input<string>;
    /**
     * Cluster name. Changing the name forces re-creation.
     */
    clusterName?: pulumi.Input<string>;
    /**
     * Service account token
     */
    token?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ClusterServiceAccount resource.
 */
export interface ClusterServiceAccountArgs {
    /**
     * Cluster name. Changing the name forces re-creation.
     */
    clusterName: pulumi.Input<string>;
}
