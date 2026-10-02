# MondialBlockChain

A lightweight, open-source blockchain framework for .NET developers.

MondialBlockChain provides building blocks for creating blockchain applications, smart contracts, decentralized systems, and blockchain research projects using C# and .NET.
---

## Features

### Core Blockchain

✅ Blockchain

✅ Blocks

✅ Transactions

✅ Genesis Block

✅ SHA256 Hashing

✅ Blockchain Validation

✅ Merkle Tree Support

✅ Proof of Work Mining

---

### Smart Contracts

✅ Contract Base Class

✅ Contract Registry

✅ Contract Deployment

✅ Contract Execution Engine

✅ Contract State Storage

---

### Events

✅ Event Bus

✅ Contract Events

✅ Blockchain Events

✅ Transaction Events

---

### Abstractions

✅ Contracts Interfaces

✅ Execution Interfaces

✅ Event Interfaces

✅ Storage Interfaces

---

## Packages

### Install All

```bash
dotnet add package MondialBlockChain
```



# Quick Start

## Create a Blockchain

```csharp
using MondialBlockChain.Core.Chain;

var blockchain = new Blockchain();

Console.WriteLine(
    $"Blocks: {blockchain.Blocks.Count}");
```

Output:

```text
Blocks: 1
```

---

## Add a Block

```csharp
using MondialBlockChain.Core.Models;

var block = new Block();

blockchain.AddBlock(block);

Console.WriteLine(
    blockchain.Blocks.Count);
```

Output:

```text
2
```

---

## Validate a Blockchain

```csharp
using MondialBlockChain.Core.Validation;

bool isValid =
    BlockchainValidator.IsValid(
        blockchain.Blocks);

Console.WriteLine(isValid);
```

Output:

```text
True
```

---

# Transactions

Create a transaction:

```csharp
using MondialBlockChain.Core.Models;

var transaction =
    new Transaction
    {
        From = "Alice",
        To = "Bob",
        Amount = 100
    };
```

---

# Mining

Mine a block using proof of work.

```csharp
using MondialBlockChain.Core.Chain;

var block = new Block();

Miner.Mine(block, 2);

Console.WriteLine(block.Hash);
```

Example:

```text
00A3F7D1...
```

---

# Smart Contracts

## Create a Contract

```csharp
using MondialBlockChain.Contracts.Base;

public class CounterContract
    : ContractBase
{
    public int Increment()
    {
        int value =
            State.Exists("count")
            ? State.Get<int>("count")
            : 0;

        value++;

        State.Set("count", value);

        return value;
    }

    public int GetCount()
    {
        return State.Exists("count")
            ? State.Get<int>("count")
            : 0;
    }

    public override object? Execute(
        string method,
        params object[] args)
    {
        return method switch
        {
            nameof(Increment) => Increment(),
            nameof(GetCount) => GetCount(),
            _ => throw new NotSupportedException()
        };
    }
}
```

---

## Deploy a Contract

```csharp
using MondialBlockChain.Contracts.Registry;

var registry =
    new ContractRegistry();

var address =
    registry.Deploy(
        new CounterContract());

Console.WriteLine(address);
```

---

## Execute a Contract

```csharp
using MondialBlockChain.Contracts.Engine;

var engine =
    new SmartContractEngine();

var contract =
    new CounterContract();

engine.Execute(
    contract,
    nameof(CounterContract.Increment));

Console.WriteLine(
    contract.GetCount());
```

Output:

```text
1
```

---

# Events

## Create Event Bus

```csharp
using MondialBlockChain.Events.Services;

var bus = new EventBus();
```

---

## Publish Event

```csharp
bus.Publish(
    "Transfer",
    new
    {
        From = "Alice",
        To = "Bob",
        Amount = 100
    });
```

---

## Subscribe to Events

```csharp
bus.EventPublished += e =>
{
    Console.WriteLine(
        $"{e.Name}");
};
```

---

# Project Structure

```text
MondialBlockChain
│
├── MondialBlockChain.Abstractions
│
├── MondialBlockChain.Core
│   ├── Blockchain
│   ├── Blocks
│   ├── Transactions
│   ├── Validation
│   └── Mining
│
├── MondialBlockChain.Contracts
│   ├── Contract Base
│   ├── Registry
│   ├── State
│   └── Execution Engine
│
├── MondialBlockChain.Events
│   ├── Event Bus
│   ├── Event Models
│   └── Event Types
│
└── MondialBlockChain.Tests
```

---

# Running Tests

```bash
dotnet test
```

Expected:

```text
Passed!
```

---

# Roadmap

## Version 1.1

- Wallets
- Digital Signatures
- Public / Private Keys
- Transaction Signing

---

# Contributing

Contributions are welcome.

1. Fork repository
2. Create feature branch
3. Add tests
4. Submit pull request


# Vision

MondialBlockChain aims to become a complete open-source blockchain ecosystem for .NET developers, providing blockchain, smart contracts, events, wallets, networking, tokens, NFTs, and decentralized application tooling through a clean NuGet package ecosystem.
