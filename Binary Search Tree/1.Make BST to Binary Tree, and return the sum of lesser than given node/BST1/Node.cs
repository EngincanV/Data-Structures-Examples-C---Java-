﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST1
{
    public class Node
    {
        public int Data;
        public Node left;
        public Node right;

        public Node(int data)
        {
            this.Data = data;
            this.left = null;
            this.right = null;
        }
    }
}
