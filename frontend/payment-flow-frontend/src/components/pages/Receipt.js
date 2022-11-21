import React from "react";

const Receipt = () => {
    return(
        <div className="container">
            <div className="py-4">
                <h2>Receipt Page</h2>
               <table>
                <tr>
                    <td>Receipt No</td> <td>1</td>
                    <td>Receipt Date</td> <td>2022-11-21</td>
                </tr>
                <tr>
                    <td>Name</td> <td>Developer</td>
                    <td>Address</td> <td>Develoepr Address</td>
                </tr>
                </table>
            </div>
        </div>
    );
}

export default Receipt;