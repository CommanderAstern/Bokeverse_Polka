import '@/styles/globals.css'
import Navbar from '../components/Layout/Navbar';
import Footer from '../components/Layout/Footer';
import { ThirdwebProvider } from "@thirdweb-dev/react";
import { MoonbaseAlpha } from "@thirdweb-dev/chains";
import AuthProvider from './AuthProvider';
import type { AppProps } from 'next/app'

function MyApp({ Component, pageProps }: AppProps) {
	return (
		<ThirdwebProvider activeChain={MoonbaseAlpha}>
				<Navbar />
				<Component {...pageProps} />
				<Footer />
		</ThirdwebProvider>
	);
}

export default MyApp;