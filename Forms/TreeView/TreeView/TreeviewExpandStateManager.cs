using System;
using System.Collections.Generic;
using System.Linq;
using Syncfusion.TreeView.Engine;
using Syncfusion.XForms.TreeView;

namespace Helpers
{
    public class TreeviewExpandStateManager : IDisposable
    {
        private SfTreeView sfTreeView;
        private HashSet<int> expandedNodeIds = new HashSet<int>();

        public TreeviewExpandStateManager(SfTreeView sfTreeView)
        {
            this.sfTreeView = sfTreeView;

            sfTreeView.NodeExpanded += SfTreeView_NodeExpanded;
            sfTreeView.NodeCollapsed += SfTreeView_NodeCollapsed;
        }

        private void SfTreeView_NodeCollapsed(object sender, NodeExpandedCollapsedEventArgs e)
        {
            var nodeModel = e.Node.Content;
            expandedNodeIds.Remove(nodeModel.GetHashCode());
        }

        private void SfTreeView_NodeExpanded(object sender, NodeExpandedCollapsedEventArgs e)
        {
            var nodeModel = e.Node.Content;
            expandedNodeIds.Add(nodeModel.GetHashCode());
        }

        public bool IsNodeExpanded(TreeViewNode node)
        {
            if (expandedNodeIds.Contains(node.Content.GetHashCode()))
            {
                return true;
            }

            return false;
        }

        public void RestoreNodeExpandedState()
        {
            if (expandedNodeIds.Count > 0)
            {
                foreach (var expandedNodeId in expandedNodeIds)
                {
                    var node = sfTreeView.Nodes.FirstOrDefault(n => n.Content.GetHashCode() == expandedNodeId);
                    if (node != null)
                    {
                        sfTreeView.ExpandNode(node);
                    }
                }
            }

            expandedNodeIds.Clear();
        }

        public void ResetNodeExpandedTracking()
        {
            expandedNodeIds.Clear();
        }

        public void Dispose()
        {
            if (sfTreeView != null)
            {
                sfTreeView.NodeExpanded -= SfTreeView_NodeExpanded;
                sfTreeView.NodeCollapsed -= SfTreeView_NodeCollapsed;
                sfTreeView = null;
            }
        }
    }
}
