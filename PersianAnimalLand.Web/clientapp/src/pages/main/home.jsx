import React from 'react';
import BannerImage from '../../../src/image/slider.jpg';

const Home = () => {
    return (
		<div class="container-fluid">
			<div class="row">
				<img src={BannerImage} style={{ width: '100%' }}  />
			</div>
		</div>
    )
}

export default Home;


