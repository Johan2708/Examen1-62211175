 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44365/',
  redirectUri: baseUrl,
  clientId: 'Examen1_App',
  responseType: 'code',
  scope: 'offline_access Examen1',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Examen1',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44365',
      rootNamespace: 'Examen1',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
