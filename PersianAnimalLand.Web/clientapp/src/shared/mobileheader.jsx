import React from 'react'
import Logo from '../shared/logo'
import { Link } from 'react-router-dom';

const MobileHeader = () => {
    return (
		<>
			<div id="kt_header_mobile" class="header-mobile">
			<Logo/>
			<div className="d-flex align-items-center">
					<button className="btn p-0 burger-icon burger-icon-left ml-4" id="kt_header_mobile_toggle">
						<span></span>
					</button>
					<button className="btn btn-icon btn-hover-transparent-white p-0 ml-3" id="kt_header_mobile_topbar_toggle">
						<span className="svg-icon svg-icon-xl">
							 
					</span>
				</button>
			</div>
		</div>
        </>

    )
}

export default MobileHeader;
