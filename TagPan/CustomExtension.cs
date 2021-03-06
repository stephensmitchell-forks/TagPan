﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TagPan
{
    public static class CustomExtension
    {
        public static List<TreeNode> GetNodeList(this TreeNodeCollection nodColl)
        {
            var ret = new List<TreeNode>();
            foreach (TreeNode node in nodColl)
            {
                ret.Add(node);
                ret.AddRange(node.Nodes.GetNodeList());
            }
            return ret;
        }
        public static List<TreeNode> GetNodeList(this List<TreeNode> nodColl)
        {
            var ret = new List<TreeNode>();
            foreach (TreeNode node in nodColl)
            {
                ret.Add(node);
                ret.AddRange(node.Nodes.GetNodeList());
            }
            return ret;
        }
        public static List<TreeNode> GetNodeList(this TreeNode node)
        {
            var ret = new List<TreeNode>();
            ret.Add(node);
            ret.AddRange(node.Nodes.GetNodeList());
            return ret;
        }
        public static List<SimpleTreeNode<DS.TagNode>> GetNodeList(this SimpleTreeNode<DS.TagNode> dnod)
        {
            var ret = new List<SimpleTreeNode<DS.TagNode>>();
            ret.Add(dnod);
            ret.AddRange(dnod.Children.GetNodeList());
            return ret;
        }
        public static List<SimpleTreeNode<DS.TagNode>> GetNodeList(this SimpleTreeNodeList<DS.TagNode> dnodColl)
        {
            var ret = new List<SimpleTreeNode<DS.TagNode>>();
            foreach (SimpleTreeNode<DS.TagNode> _dnode in dnodColl)
            {
                ret.Add(_dnode);
                ret.AddRange(_dnode.Children.GetNodeList());
            }
            return ret;
        }
        public static List<SimpleTreeNode<DS.TagNode>> GetNodeList(this List<SimpleTreeNode<DS.TagNode>> dnodColl)
        {
            var ret = new List<SimpleTreeNode<DS.TagNode>>();
            foreach (SimpleTreeNode<DS.TagNode> _dnode in dnodColl)
            {
                ret.Add(_dnode);
                ret.AddRange(_dnode.Children.GetNodeList());
            }
            return ret;
        }
        public static IEnumerable<T> IntersectNonEmpty<T>(this IEnumerable<IEnumerable<T>> lists)
        {
            var nonEmptyLists = lists.Where(l => l.Any());
            return nonEmptyLists.Aggregate((l1, l2) => l1.Intersect(l2));
        }
    }
}
