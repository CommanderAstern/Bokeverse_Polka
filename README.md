<a name="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
  <a href="https://github.com/Yukino2002/Bokeverse">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

<h3 align="center">Bokeverse</h3>

  <p align="center">
    project_description
    <br />
    <a href="https://github.com/Yukino2002/Bokeverse"><strong>Explore the docs »</strong></a>
    <br />
    <br />
    <a href="https://github.com/Yukino2002/Bokeverse">View Demo</a>
    ·
    <a href="https://github.com/Yukino2002/Bokeverse/issues">Report Bug</a>
    ·
    <a href="https://github.com/Yukino2002/Bokeverse/issues">Request Feature</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#technologies-used">Technologies Used</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

[![Product Name Screen Shot][product-screenshot]](https://example.com)

The game is a decentralized 2D open-world RPG with turn-based battles. It is set in a fantasy world, allowing players to explore, fight monsters and possess NFT characters and collectibles registered to their wallet address. We have also included a trading marketplace for NFTs and a QR code generation system to easily access and purchase these NFTs.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



## Technologies Used

* [Unity Engine](https://unity.com/)
  * We used version 2021.3.16f1 of the Unity Engine to create the game.

* [Thirdweb](https://thirdweb.com/)
  * We used the Thirdweb web3 development framework to integrate web3 into our game and website.
  * Solutions used:
    * GamingKit:
      * Utilised Thirdweb UnitySDK to connect players' wallets, interact with the smart contracts within the game.
      * Additionally, we used the Thirdweb dashboard to manage and interact with the smart contracts deployed in the game and the marketplace.
    * ContractKit: 
        * With the Thirdweb ContractKit, we wrote the contracts for our game and marketplace.
        * The Thirdweb ERC1155 base contracts were utilized for creating NFTs and other related purposes.
    * UIKit:
      * We used the Thirdweb UIKit components to create the website and marketplace more efficiently. Some of the components used are: 
        * Connect Wallet Button: The Connect Wallet Button connects players' wallets (MetaMask, Coinbase Wallet, etc.) within the website.
        * NFT Metadata Renderer: The NFT Metadata Renderer displays the metadata of NFTs and lists them on the marketplace.    
    * ReactSDK: We utilised the Thirdweb ReactSDK for the development of our website, QR code redemption and marketplace. Some of the components and functions used are:
      * ThirdwebProvider
        * Wrapper component for the ReactSDK, used to connect wallets, interact with the contracts etc.
      * Web3Button:
        * Interact and call on-chain functions on our contracts.
      * useActiveListings
        * Fetched all active listings from our marketplace contract.
      * useContract
        * Utilised this to resolve the contract addresses into smart contract instances.
      * ConnectWallet
        * Allowed players to connect their wallets to the website, access the marketplace, etc.
      * useAddress
        * Access the address of the connected wallet.
      * ChainId
        * Set the chain ID of the connected wallet to the chain ID of the smart contracts.
    * Thirdweb Storage:
      * We have used the Thirdweb Storage to store our QR code and NFT generation scripts.

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

This is an example of how to list things you need to use the software and how to install them.
* npm
  ```sh
  npm install npm@latest -g
  ```

### Installation

1. Get a free API Key at [https://example.com](https://example.com)
2. Clone the repo
   ```sh
   git clone https://github.com/Yukino2002/Bokeverse.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```js
   const API_KEY = 'ENTER YOUR API';
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Usage

The links to the working demos and articles of the project are as follows:

* [Website](https://bokemon.vercel.app/)
* [Game](https://bokemon.vercel.app/game)
* [Medium Article](https://medium.com/@yukino2002/bokemon-a-decentralized-2d-open-world-rpg-with-turn-based-battles-2b3b3f3e1c5a)

### Playing the Game

* On launch, the user is presented with the start menu, where they must connect their wallet, to play the game. We have included MetaMask, Coinbase Wallet etc. as the wallet options.

  * <img src="website/public/StartMenu.jpg" />

* Once the wallet is connected, players can explore the map, battle other Bokemons, etc. But first, they must have a Bokemon linked to their wallet address. Without it, they won't be able to access the wild grass where Bokemons appear. A message will appear, instructing the player to speak to the white-haired NPC to get a starter Bokemon.

  * <img src="website/public/Wild.jpg" />

* The player goes to the white-haired NPC, and if they don't have a Bokemon and their party size is zero, they'll be asked to sign a transaction to get a Bokemon NFT. The NFT will be made using the player's wallet as the seed and sent to the wallet. The user may have to wait briefly for the transaction to complete. If your transaciton fails, or you reject it by mistake, don't worry! You can try again.

  * <img src="website/public/StarterBokemon.jpg" />

* You receive Walruse, the beloved Ice-type Bokemon! You can now venture into the wild grass and battle other Bokemons. On the battle screen, you have options to attack, flee, or switch Bokemons. Remember to use the right attack for the right Bokemon, as some attacks are more effective against certain types!

  * <img src="website/public/StarterWalruse.jpg" />

* After winning a battle, you receive experience points. This triggers a write operation to update the experience data on the contract for your Bokemon. If you reject the transaction, your Bokemon won't level up. If you accept it, you'll see a similar message asking you to wait for the transaction to finish.

  * <img src="website/public/IncreaseExperience.jpg" />

* If all the bokemons in your party are defeated, you'll exit the battle and be asked to heal them. You can visit the sleeping healing tree to heal your Bokemons.

  * <img src="website/public/PartyDefeated.jpg" />

* You're all set to go! You can now battle other Bokemons, explore the map, and have fun! If you want more Bokemons, you can visit the Bokeverse marketplace and buy a Bokemon NFT or redeeem through external QR codes.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Roadmap

- [ ] Feature 1
- [ ] Feature 2
- [ ] Feature 3
    - [ ] Nested Feature

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



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

Your Name - [@twitter_handle](https://twitter.com/twitter_handle) - email@email_client.com

Project Link: [https://github.com/Yukino2002/Bokeverse](https://github.com/Yukino2002/Bokeverse)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ACKNOWLEDGMENTS -->
## Acknowledgments

* []()
* []()
* []()

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/Yukino2002/Bokeverse.svg?style=for-the-badge
[contributors-url]: https://github.com/Yukino2002/Bokeverse/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Yukino2002/Bokeverse.svg?style=for-the-badge
[forks-url]: https://github.com/Yukino2002/Bokeverse/network/members
[stars-shield]: https://img.shields.io/github/stars/Yukino2002/Bokeverse.svg?style=for-the-badge
[stars-url]: https://github.com/Yukino2002/Bokeverse/stargazers
[issues-shield]: https://img.shields.io/github/issues/Yukino2002/Bokeverse.svg?style=for-the-badge
[issues-url]: https://github.com/Yukino2002/Bokeverse/issues
[license-shield]: https://img.shields.io/github/license/Yukino2002/Bokeverse.svg?style=for-the-badge
[license-url]: https://github.com/Yukino2002/Bokeverse/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/linkedin_username
[product-screenshot]: website/public/Wild.jpg
[Next.js]: https://img.shields.io/badge/next.js-000000?style=for-the-badge&logo=nextdotjs&logoColor=white
[Next-url]: https://nextjs.org/
[React.js]: https://img.shields.io/badge/React-20232A?style=for-the-badge&logo=react&logoColor=61DAFB
[React-url]: https://reactjs.org/
[Unity]: https://img.shields.io/badge/Unity-100000?style=for-the-badge&logo=unity&logoColor=white
[Unity-url]: https://unity.com/
[Thirdweb]: https://img.shields.io/badge/Thirdweb-000000?style=for-the-badge&logo=thirdweb&logoColor=white

- [DoTween](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676) - An animation package for Unity.