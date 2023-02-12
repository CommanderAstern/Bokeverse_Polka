<a name="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

## Table of Contents
<details> 
  <ul>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#overview">Overview</a></li>
        <ul>
          <li><a href="#game-smart-contract">Game Smart Contract</a></li>
          <li><a href="#marketplace">Marketplace</a></li>
          <li><a href="#qr-redeeming">QR Redeeming</a></li>
        </ul>
        <li><a href="#technologies-used">Technologies Used</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
        <li><a href="#running-the-game">Running the game</a></li>
        <li><a href="#deploying-the-smart-contract">Deploying the smart contract</a></li>
        <li><a href="#deploying-the-website">Deploying the website</a></li>
        <li><a href="#minting-bokemonsnfts-to-your-account">Minting Bokemons(NFTs) to your account</a></li>
        <li><a href="#creating-a-qr-code-to-scan">Creating a QR Code to Scan</a></li>
      </ul>
    </li>
    <li>
      <a href="#usage">Usage</a>
      <ul>
        <li><a href="#demo-links">Demo Links</a></li>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#playing-the-game">Playing the Game</a></li>
        <li><a href="#navigating-the-website">Navigating the Website</a></li>
      </ul>
    </li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#acknowledgements">Acknowledgements</a></li>
    <li><a href="#contact">Contact</a></li>
  </ul>
</details>

## About The Project

![Town Square](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/uy2o22cqgz8s9cfv2j1g.jpg)

The game is a decentralized 2D open-world RPG with turn-based battles. It is set in a fantasy world, allowing players to explore, fight monsters and possess NFT characters and collectibles registered to their wallet address. We have also included a trading marketplace for NFTs and a QR code generation system to easily access and purchase these NFTs.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Overview

### Game Smart Contract

The smart contract that the Bokeverse game runs on is a non-fungible token (NFT) contract that is built on the ERC1155Base contract by thirdweb which implements the ERC1155 NFT standard along with some additional functionality. This contract allows the creation of unique, collectible bokemons that can be owned by users and can have a unique experience level assigned to them.

The contract includes the following functions:

- `MintTo`: 
  This function is responsible for minting new bokemons. It takes in parameters such as the recipient's address, the token ID, token URI, and the amount to be minted. This function also handles assigning a unique token ID to the bokemon if none is provided.

- `Mint`: 
  This function is a higher-level implementation of the MintTo function that takes in additional parameters such as the experience level of the bokemon being minted.

- `GetBokemon`: 
  This function returns the token URI and experience level of a bokemon specified by its ID.

- `GetBokemonUri`: 
  This function returns the token URI of a bokemon specified by its ID.

- `GetBokemonPerUser`: 
  This function returns an array of all the bokemons owned by a specific user.

- `IncreaseExperience`: 
  This function allows for the experience level of a bokemon to be increased.

- `IncreaseExperienceBatch`: 
  This function allows for the experience level of multiple bokemons to be increased in bulk.

- `Redeem`: 
  This function allows users to redeem a bokemon by providing a redeem code. If the code is correct, the user will receive the specified bokemon.

Overall, the Bokeverse contract allows for the creation and management of unique, collectible bokemons that can be owned by users and can have a unique experience level assigned to them. This contract provides a number of functions that allow users to interact with their bokemons and manage their experience levels.

### Marketplace

The NFT marketplace for Bokeverse was built on the marketplace contract by Thirdweb. The frontend of the marketplace was developed using Thirdweb and Tailwind. The marketplace provides a platform for users to view and purchase Bokemons that are listed for sale by other users.

The marketplace includes the following functions:

- View Listings: 
  Users can view all the Bokemons that are currently listed for sale on the marketplace.

- Buy Bokemon: 
  Users can purchase a Bokemon by selecting the desired listing and submitting the transaction to the smart contract.

- List Bokemon (Workaround using Thirdweb Dashboard): 
  Users can list a Bokemon for sale by interacting with the smart contract via the Thirdweb dashboard. They can specify the desired price and other relevant information for the listing.

The NFT marketplace for Bokeverse provides a user-friendly platform for buying and selling Bokemons. The integration with the smart contract allows for secure and transparent transactions on the blockchain. 

### QR Redeeming

The QR Redeeming feature in Bokeverse allows users to redeem a Bokemon by uploading or scanning a QR code using their camera. This feature is part of the plan to make physical trading cards for collecting Bokemons. The trading cards will include a QR code that can be scanned to redeem the corresponding Bokemon.

The QR Redeeming feature provides a convenient way for users to collect Bokemons and adds an additional layer of engagement to the Bokeverse game. By allowing for physical trading cards, the QR Redeeming feature combines the traditional collectible experience with the benefits of blockchain technology. 

Users can generate a new QR code at website using `npm run generate` . This code can be printed on a physical trading card or displayed on a screen for scanning.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Technologies Used

* [Unity Engine](https://unity.com/)
  * We used version 2021.3.16f1 of the Unity Engine to create the game.
  * Utilized [DoTween](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676) animation package for Unity.

* [Thirdweb](https://thirdweb.com/)
  * We used the Thirdweb web3 development framework to integrate web3 into our game and website.
  * Solutions used:
    * GamingKit:
      * Utilised Thirdweb UnitySDK to connect players' wallets, interact with the smart contracts within the game.
      * Additionally, we used the Thirdweb dashboard to manage and interact with the smart contracts deployed in the game and the marketplace.
    * ContractKit: 
        * With the Thirdweb ContractKit, we wrote the contracts for our game and marketplace.
        * The [Thirdweb ERC1155 base](https://thirdweb.com/goerli/0xfbFaAB92b0444c36770190F22ea0C116B0Dea1a2/) contracts were utilized for creating NFTs and other related purposes.
        * THe [Thirdweb marketplace contracts](https://thirdweb.com/goerli/0x61067EbAe343f6047271704d63B3f493c0810742/) were used to create the marketplace for our NFTs.
    * UIKit:
      * We used the Thirdweb UIKit components to create the website and marketplace more efficiently. Some of the components used are: 
        * Connect Wallet Button: The Connect Wallet Button connects players' wallets (MetaMask, Coinbase Wallet, etc.) within the website.
        * Web3Button: The Web3Button allows players to interact with the smart contracts on the blockchain.
        * NFT Metadata Renderer: The NFT Metadata Renderer displays the metadata of NFTs and lists them on the marketplace.    
    * ReactSDK: We utilised the Thirdweb ReactSDK for the development of our website, QR code redemption and marketplace. Some of the functions used are:
        * Connection of players' digital wallets, including MetaMask and Coinbase Wallet, directly within the website.
        * Interact and call on-chain functions on our website.
    * Thirdweb Storage:
      * We have used the Thirdweb Storage to store our Bokemon(NFT) metadata and image to IPFS which are implemented in the QR code and NFT generation scripts.

* [Scenario.gg](https://www.scenario.gg/)
  * We made use of AI-generated assets for our game. These assets include:
    * Playable Bokemon characters. Some of the characters are:
      * <img src="contract/images/Steeleton.png" width="300" /> <img src="contract/images/Girasion.png" width="300"/>
    * Start menu and Battleground backgrounds
      * <img src="Bokemon/Assets/gfx/start-menu.png" width="300" /> <img src="Bokemon/Assets/Battle/battle-background.png" width="300" />

* [Next.js](https://nextjs.org/)
  * We used the powerful Next.js framework to create our website.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Getting Started

Before getting a local copy up, you must ensure that you have the necessary software required.

### Prerequisites

* Unity
  ```sh
  https://unity3d.com/get-unity/download
  ```
* Node.js
  ```sh
    https://nodejs.org/en/download/
  ```

### Installation



1. Clone the repo
   ```sh
   git clone https://github.com/Yukino2002/Bokeverse.git
   ```

### Running the game

1. Open the project `Bokemon` in Unity (Editor version is 2021.3.16f1)
2. Open the scene "SampleScene.unity" in `/Bokemon/Assets/Scenes/SampleScene.unity`
3. Open your `Build settings`, select `WebGL` as the target platform.
4. Open `Player settings` > `Resolution and Presentation` and under `WebGLTemplate` choose `Thirdweb`.
5. Save and click `Build and Run` to test out your game in a browser.


### Deploying the smart contract
1. Navigate to the folder `contract`
```sh
cd contract
```
2. Deploy the contract using thirdweb ContractKit
```sh
npx thirdweb deploy .
```
3. Confirm the 2 transactions on unitys dashboard

### Deploying the website
1. Navigate to the folder `website`
```sh
cd website
```
2. Install the required dependencies 
```sh
npm i
```
3. Run the server
```sh
npm run dev
```
### Minting Bokemons(NFTs) to your account
You can get a starting Bokemon(Walruse) from the game. If you want another Bokemon you can use the scripts
1. Navigate to the folder `website`
```sh
cd website
```
2. Navigate to `src\scripts\deployThirdWebNFT.js` and in 
```js
var result = await contract.call("mint", "0xB7E99669e9eDdD2975511FBF059d01969f43D409", uri, 1);
```
replace `0xB7E99669e9eDdD2975511FBF059d01969f43D409` with your own contract address

3. Run `createBokemon` script
```sh
npm run createBokemon
```
### Creating a QR Code to Scan
1. Navigate to the folder `website`
```sh
cd website
```
2. Run `generate` script
```sh
npm run createBokemon
```
3. QR code is generated in the `src\scripts\QRCodeResults` Folder
4. Scan the QR code and obtain a Shiny Girason!!!!


<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Usage

### Demo Links
The links to the working demos and articles of the project are as follows:

* [Website](https://bokemon.vercel.app/)
* [Game](https://bokemon.vercel.app/game)
* [Dev.to Article]()
* [Marketplace Thirdweb dashboard](https://thirdweb.com/goerli/0x61067EbAe343f6047271704d63B3f493c0810742)
* [Game Contract dashboard](https://thirdweb.com/goerli/0xfbFaAB92b0444c36770190F22ea0C116B0Dea1a2)


### Prerequisites

* [MetaMask](https://metamask.io/), [Coinbase](https://wallet.coinbase.com/) or any other wallet that supports the Ethereum network.
* Some Goerli ETH to carry out transactions and pay for gas fees. You can grab some from a faucet [here](https://testnet.help/en/ethfaucet/goerli#log).

### Playing the Game

* On start, the user sees the start menu, where they must connect a wallet to play. The wallet options are MetaMask, Coinbase Wallet, etc.

![Start Menu](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/daqs6cobpvc8l0m2hvvg.jpg)

* With a connected wallet, players can explore, battle Bokemons, etc. They must first have a Bokemon linked to their wallet. Otherwise, they can't access the wild grass where Bokemons appear. A message appears, telling the player to talk to the white-haired NPC for a starter Bokemon.

![Getting Bokemon](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/xr7cl0rmcxzpexxbt2d6.jpg)

* The player visits the white-haired NPC. If they lack a Bokemon and their party size is 0, they'll sign a transaction for a Bokemon NFT. The NFT is made using the player's wallet as seed and sent to the wallet. Wait briefly for transaction completion. If transaction fails or rejected, try again.

![Transaction Execution](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/2mc8w9ywxvmqetppiqwl.jpg)

* Receive Walruse, the popular Ice-type Bokemon! Explore the wild grass and battle other Bokemons. On the battle screen, you can attack, flee, or switch Bokemons. Use the right attack for the right Bokemon as some are more effective against certain types. Use 'Z' to choose and 'X' to return.

![The Battle Screen](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/1hb0j2k20od2ix6bw81i.jpg)

* After winning, experience points are earned and a write operation updates the Bokemon data. If the transaction is rejected, the Bokemon won't level up. If accepted, you'll see a message to wait for the transaction to complete.

* If all party Bokemons are defeated, the battle ends and you'll be asked to heal them. Go to the sleeping healing tree to heal your Bokemons.

![Heal Bokemons](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/78twf6bs6s74cjkh96l8.jpg)

### Navigating the Website

* You can purchase bokemons from the marketplace and increase your party size, and find rare bokemons!

![Marketplace](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/cpkc9qqzjvfdlrifpcct.jpg)

* You can also redeem bokemons from QR codes.

![Redeem](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/025ogsioe9cw9p1qm9be.jpg)

You're all set to go! You can now battle other Bokemons, explore the map, and have fun! If you want more Bokemons, you can visit the Bokeverse marketplace and buy a Bokemon NFT or redeeem through external QR codes.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Roadmap

- [ ] Improving the graphics and overall visual appearance of the game

- [ ] Adding more NFT bokemons and collectibles for players to possess

- [ ] Adding more quest lines, battles, and exploration elements to the game

- [ ] Adding more customization options for players to personalize their characters and homes

- [ ] Introducing new gameplay elements such as PvP arenas, boss battles, and more.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Contributing

Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Acknowledgements

 - [Best-README-Template](https://github.com/othneildrew/Best-README-Template)
 - [Marketplace-Frontend](https://blog.thirdweb.com/guides/how-to-create-an-nft-marketplace-with-nextjs-and-thirdweb-on-polygon-network/)
 - [Sound Tracks](https://pixabay.com/music/search/game%20background/?manual_search=1&order=None)
  - [Tileset](https://cypor.itch.io/12x12-rpg-tileset)

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Contact

Pratik Jallan - [LinkedIn](https://www.linkedin.com/in/pratik-jallan/) - pratikjalan11@gmail.com

Asim Jawahir - [LinkedIn](https://www.linkedin.com/in/asimjawahir/) - asimjawahir123@gmail.com

<p align="right">(<a href="#readme-top">back to top</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/Yukino2002/Bokeverse.svg?style=for-the-badge
[contributors-url]: https://github.com/Yukino2002/Bokeverse/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Yukino2002/Bokeverse.svg?style=for-the-badge
[forks-url]: https://github.com/Yukino2002/Bokeverse/network/members
[stars-shield]: https://img.shields.io/github/stars/Yukino2002/Bokeverse.svg?style=for-the-badge
[stars-url]: https://github.com/Yukino2002/Bokeverse/stargazers
[issues-shield]: https://img.shields.io/github/issues/Yukino2002/Bokeverse.svg?style=for-the-badge
[issues-url]: https://github.com/Yukino2002/Bokeverse/issues
[license-shield]: https://img.shields.io/github/license/Yukino2002/Bokeverse.svg?style=for-the-badge
[license-url]: https://github.com/Yukino2002/Bokeverse/blob/main/LICENSE.txt
