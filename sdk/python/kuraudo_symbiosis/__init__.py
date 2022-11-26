# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from . import _utilities
import typing
# Export this package's modules as members:
from .cluster import *
from .cluster_service_account import *
from .node_pool import *
from .provider import *
from .team_member import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import kuraudo_symbiosis.config as __config
    config = __config
else:
    config = _utilities.lazy_import('kuraudo_symbiosis.config')

_utilities.register(
    resource_modules="""
[
 {
  "pkg": "symbiosis",
  "mod": "index/cluster",
  "fqn": "kuraudo_symbiosis",
  "classes": {
   "symbiosis:index/cluster:Cluster": "Cluster"
  }
 },
 {
  "pkg": "symbiosis",
  "mod": "index/clusterServiceAccount",
  "fqn": "kuraudo_symbiosis",
  "classes": {
   "symbiosis:index/clusterServiceAccount:ClusterServiceAccount": "ClusterServiceAccount"
  }
 },
 {
  "pkg": "symbiosis",
  "mod": "index/nodePool",
  "fqn": "kuraudo_symbiosis",
  "classes": {
   "symbiosis:index/nodePool:NodePool": "NodePool"
  }
 },
 {
  "pkg": "symbiosis",
  "mod": "index/teamMember",
  "fqn": "kuraudo_symbiosis",
  "classes": {
   "symbiosis:index/teamMember:TeamMember": "TeamMember"
  }
 }
]
""",
    resource_packages="""
[
 {
  "pkg": "symbiosis",
  "token": "pulumi:providers:symbiosis",
  "fqn": "kuraudo_symbiosis",
  "class": "Provider"
 }
]
"""
)