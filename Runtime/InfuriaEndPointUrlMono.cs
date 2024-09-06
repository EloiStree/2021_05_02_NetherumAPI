using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfuriaEndPointUrlMono : MonoBehaviour
{

    [Header("{0} Is api key")]
    public string m_etherMainnetMain = "https://mainnet.infura.io/v3/{0}";
    public string m_etherHoleskyTest = "https://holesky.infura.io/v3/{0}";
    public string m_etherSepoliaTest = "https://sepolia.infura.io/v3/{0}";
    public string m_lineaMainnetMain = "https://linea-mainnet.infura.io/v3/{0}";
    public string m_lineaSepoliaTest = "https://linea-sepolia.infura.io/v3/{0}";
    public string m_gasApiMainnet = "https://gas.api.infura.io/v3/{0}";


    public string m_urlEthereum = "https://docs.infura.io/api/networks/ethereum";
    public string m_urlLinea = "https://docs.infura.io/api/networks/linea";
}


//https://gas.api.infura.io/networks/${chainId}/busyThreshold
//https://gas.api.infura.io/networks/${chainId}/baseFeePercentile
//https://gas.api.infura.io/networks/${chainId}/suggestedGasFees
//https://docs.infura.io/api/infura-expansion-apis/gas-api/supported-networks
//`https://gas.api.infura.io/v3/${process.env.INFURA_API_KEY}/networks/${chainId}/suggestedGasFees`