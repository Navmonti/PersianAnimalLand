import React from 'react';
import Logo from '../../shared/logo';

const Member = () => {
    return (
        <>
            <div className="d-flex flex-column flex-root">
                <div className="d-flex flex-row flex-column-fluid page">
                    <div className="header-menu aside aside-left  aside-fixed  d-flex flex-column flex-row-auto" id="kt_aside">
                        <div className="brand flex-column-auto " id="kt_brand" kt-hidden-height="65"  >
                            <button className="brand-toggle btn btn-sm px-0" id="kt_aside_toggle">
                                <span className="svg-icon svg-icon svg-icon-xl">
                                    <Logo />
                                </span>
                            </button>
                        </div>
                    </div>
                    <div className="d-flex flex-column flex-row-fluid wrapper" id="kt_wrapper">
                        <div id="kt_header" className="header  header-fixed ">
                            <div className=" container-fluid  d-flex align-items-stretch justify-content-between">
                                <div className="header-menu-wrapper header-menu-wrapper-left" id="kt_header_menu_wrapper">
                                    <div id="kt_header_menu" className="header-menu header-menu-mobile  header-menu-layout-default ">

                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="content  d-flex flex-column flex-column-fluid" id="kt_content">
                            <div className="d-flex flex-column-fluid">
                                <div className=" container ">
                                    <div className="row">
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div className="footer bg-white py-4 d-flex flex-lg-column " id="kt_footer">
                            <div className=" container-fluid  d-flex flex-column flex-md-row align-items-center justify-content-between">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default Member;