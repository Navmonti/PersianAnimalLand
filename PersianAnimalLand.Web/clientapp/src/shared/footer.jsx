import React from 'react';
import dogImage from '../image/cat.png';
import catImage from '../image/dog.png';

const ContactUs = () => {
    return (
        <div className="footer bg-white py-4 d-flex flex-lg-column" id="kt_footer">
            <div className="container-fluid d-flex flex-column flex-md-row align-items-center justify-content-between">
                <img src={dogImage} />
                <img src={catImage} />
            </div>
        </div>
    )
}

export default ContactUs;