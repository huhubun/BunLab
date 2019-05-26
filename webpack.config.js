const path = require('path')
const webpack = require('webpack')
const VueLoaderPlugin = require('vue-loader/lib/plugin')
const HtmlWebpackPlugin = require('html-webpack-plugin')
const MiniCssExtractPlugin = require("mini-css-extract-plugin")
const CopyPlugin = require('copy-webpack-plugin')

const isDev = process.env.NODE_ENV === 'development'

const config = {
    entry: path.join(__dirname, 'src/index.js'),
    output: {
        filename: 'bundle.[hash:8].js',
        path: path.join(__dirname, 'dist')
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            {
                test: /\.js$/,
                loader: 'babel-loader',
                options: {
                    presets: ['@babel/preset-env']
                }
            }
        ]
    },
    plugins: [
        new webpack.DefinePlugin({
            'process.env': {
                NODE_ENV: isDev ? '"development"' : '"production"'
            }
        }),
        new VueLoaderPlugin()
    ]
}

if (isDev) {
    config.module.rules.push({
        test: /\.css$/,
        use: [
            'vue-style-loader',
            'css-loader',
            {
                loader: 'postcss-loader',
                options: {
                    sourceMap: true
                }
            }
        ]
    })

    config.module.rules.push({
        test: /\.styl(us)?$/,
        use: [
            'vue-style-loader',
            'css-loader',
            {
                loader: 'postcss-loader',
                options: {
                    sourceMap: true
                }
            },
            'stylus-loader'
        ]
    })

    config.plugins.push(new HtmlWebpackPlugin({
        filename: 'index.html',
        template: 'assets/index.dev.html',
        inject: true
    }))

    config.plugins.push(new CopyPlugin([
        {
            from: 'config/config.dev.js',
            to: 'config/config.dev.js'
        }
    ]))

    config.devtool = '#cheap-module-eval-source-map'

    config.devServer = {
        port: 8000,
        host: '0.0.0.0',
        overlay: {
            errors: true
        },
        hot: true
    }

    config.plugins.push(
        new webpack.HotModuleReplacementPlugin(),
        new webpack.NoEmitOnErrorsPlugin()
    )
}
else {
    config.entry = {
        app: path.join(__dirname, 'src/index.js'),
        vendor: ['vue']
    }
    config.output.filename = '[name].[chunkhash:8].js'

    config.module.rules.push({
        test: /\.css$/,
        use: [
            MiniCssExtractPlugin.loader,
            'css-loader',
            {
                loader: 'postcss-loader',
                options: {
                    sourceMap: true
                }
            }
        ]
    })

    config.module.rules.push({
        test: /\.styl(us)?$/,
        use: [
            MiniCssExtractPlugin.loader,
            'css-loader',
            {
                loader: 'postcss-loader',
                options: {
                    sourceMap: true
                }
            },
            'stylus-loader'
        ]
    })

    config.plugins.push(new MiniCssExtractPlugin({
        filename: '[name].[hash].css',
        chunkFilename: '[id].[hash].css'
    }))

    config.optimization = {
        splitChunks: {
            cacheGroups: {
                commons: {
                    chunks: 'initial',
                    minChunks: 2,
                    maxInitialRequests: 5,
                    minSize: 0
                },
                vendor: {
                    test: /node_modules/,
                    chunks: 'initial',
                    name: 'vendor',
                    priority: 10,
                    enforce: true
                }
            }
        },
        runtimeChunk: true
    }

    config.plugins.push(new HtmlWebpackPlugin({
        filename: 'index.html',
        template: 'assets/index.prod.html',
        inject: true
    }))

    config.plugins.push(new CopyPlugin([
        {
            from: 'config/config.prod.js',
            to: 'config/config.prod.js'
        }
    ]))

    config.externals = {
        'vue': 'Vue'
    }
}


module.exports = config
