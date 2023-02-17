import React from 'react';
import AuthProvider from './AuthProvider';

class App extends React.Component {
  render() {
    return (
        <div className="mt-[80px] container-iframe">
          <iframe src="https://gateway.ipfscdn.io/ipfs/QmSPCJXfEoNXvFkpEsbk3r86edrZqoL4U5oLWJrGhMCQCy/" className="responsive-iframe"></iframe>
        </div>
    );
  }
}

export default App;
