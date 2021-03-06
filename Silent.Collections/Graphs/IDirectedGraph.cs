﻿using System;
using System.Collections.Generic;

namespace Silent.Collections
{
    public interface IDirectedGraph<T> : IAdjacencyMatrix<T> where T : IEquatable<T>
    {
        Vertex<T> this[T value] { get; }

        IReadOnlyCollection<Vertex<T>> Vertices { get; }

        IReadOnlyCollection<Edge<T>> Edges { get; }

        bool SetVertex(Vertex<T> vertex);

        bool SetEdge(Vertex<T> sourceVertex, Vertex<T> targetVertex, int weight);

        bool RemoveVertex(Vertex<T> vertex);

        bool RemoveEdge(Edge<T> edge);
    }
}
