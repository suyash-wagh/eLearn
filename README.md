# eLearn - Microservices Project on .NET Platform

## 🛠️ Microservices Overview

### **Catalog Microservice**
- **Technology**: ASP.NET Core Minimal APIs, .NET 8, C# 12
- **Architecture**: Vertical Slice Architecture with Feature Folders
- **Core Features**:
  - CQRS implementation using MediatR
  - Validation Pipeline Behaviors with MediatR and FluentValidation
  - Marten library for PostgreSQL Document DB
  - Cross-cutting concerns: Logging, global Exception Handling, Health Checks
- **Containerization**: Dockerfile and docker-compose for multi-container setup

### **Basket Microservice**
- **Technology**: ASP.NET 8 Web API
- **Features**:
  - Follows REST API principles with CRUD operations
  - Redis as a Distributed Cache
  - Implements Proxy, Decorator, and Cache-aside Design Patterns
  - Sync Communication with Discount Microservice via gRPC
  - Publishes BasketCheckout Queue using RabbitMQ and MassTransit

### **Discount Microservice**
- **Technology**: ASP.NET gRPC Server
- **Features**:
  - High-performance gRPC communication with Basket Microservice
  - SQLite for data persistence
  - RabbitMQ for Async Microservices Communication
  - Publishes and subscribes to BasketCheckout event queue

### **Ordering Microservice**
- **Technology**: ASP.NET Core Web API
- **Architecture**: DDD, CQRS, and Clean Architecture
- **Features**:
  - Integration Events, Domain Events
  - Entity Framework Core with SQL Server
  - RabbitMQ for consuming BasketCheckout events via MassTransit
  - Auto database migration on application startup

### **YARP API Gateway**
- **Technology**: YARP Reverse Proxy
- **Features**:
  - Gateway Routing Pattern
  - Configuration for Route, Cluster, Path, Transform, Destinations
  - Rate Limiting with FixedWindowLimiter

## 🚀 Project Highlights

- **E-Commerce Modules**: Fully developed Product, Basket, Discount, and Ordering microservices.
- **Database Integration**: Combines relational (SQL Server, SQLite) and NoSQL (PostgreSQL DocumentDB, Redis) databases.
- **Microservices Communication**:
  - Sync communication using gRPC
  - Async communication with RabbitMQ (Publish/Subscribe Topic Exchange Model)
- **Containerization**: Dockerized microservices and backing services, orchestrated with Docker Compose.

---

## 📦 Docker Compose Setup

This project uses Docker Compose to:

- Run all microservices in a multi-container environment.
- Orchestrate backing services such as databases, distributed caches, and message brokers.
- Set environment variables for configuration overrides.

---

## 🛠 Prerequisites

- .NET 8 SDK
- Docker & Docker Compose
- PostgreSQL, Redis, RabbitMQ, SQLite, and SQL Server installed or configured in Docker Compose
